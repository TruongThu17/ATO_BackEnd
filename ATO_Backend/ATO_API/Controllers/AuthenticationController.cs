using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ATO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IConfiguration _configuration;
        public AuthenticationController(UserManager<Account> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IConfiguration configuration
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {
            try
            {
                // Check user in the database
                var user = await _userManager.Users
                    .Where(u => u.UserName == model.username)
                    .FirstOrDefaultAsync();

                if (user == null)
                {
                    throw new Exception("Tài khoản của bạn không tồn tại!");
                }

                // Check user is active
                if (!user.isAccountActive)
                {
                    throw new Exception("Tài khoản của bạn đã bị khóa!");
                }

                // Verify password if provided
                if (!string.IsNullOrEmpty(model.password))
                {
                    if (!await _userManager.CheckPasswordAsync(user, model.password))
                    {
                        throw new Exception("Sai mật khẩu đăng nhập!");
                    }
                }
                var userRoles = await _userManager.GetRolesAsync(user);
                var role = userRoles.FirstOrDefault();
                var authClaims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.Fullname),
                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                if (!String.IsNullOrEmpty(user.AvatarURL))
                {
                    authClaims.Add(new Claim("AvatarUrl", user.AvatarURL));
                }
                var Bear = GetToken(authClaims);

                ResponseLogin respone = new ResponseLogin();
                respone.Bear = new JwtSecurityTokenHandler().WriteToken(Bear);
                respone.Expiration = Bear.ValidTo;
                respone.Role = role;
                return Ok(respone);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    //Message = "Đã xảy ra lỗi trong quá trình xử lý"
                    Message = ex.Message,
                });
            }
        }
        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var expirationTimeUtc = DateTime.UtcNow.AddHours(72);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.SpecifyKind(expirationTimeUtc, DateTimeKind.Utc),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return token;
        }
    }
}
