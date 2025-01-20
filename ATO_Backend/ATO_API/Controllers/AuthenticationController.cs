using ATO_API.Helper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using Service.AccountSer;
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
        private readonly IAccountService _accountService;
        private readonly IMemoryCache _cache;
        private readonly TokenHelper _tokenHelper;
        public AuthenticationController(UserManager<Account> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IConfiguration configuration,
            IAccountService accountService,
            IMemoryCache cache,
            TokenHelper tokenHelper
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _accountService = accountService;
            _cache = cache;
            _tokenHelper = tokenHelper;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {
            try
            {
                var response = await _accountService.LoginAsync(model);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = ex.Message,
                });
            }
        }
        [HttpPost("forgot-password/send-otp")]
        public async Task<IActionResult> ForgotPasswordSendOTP([FromBody] ForgotPassword_Request_DTO model)
        {
            try
            {
                var result = await _accountService.ForgotPasswordSendOTPAsync(model.username);
                return Ok(new ResponseVM_Email()
                {
                    Status = result.Status,
                    Message = "Mã xác thực đã được gửi tới email của bạn!",
                    toEmail= result.toEmail,
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }
        [HttpPost("forgot-password/verify-OTP")]
        public async Task<ActionResult<string>> VerifyOtpAsync(string email, string otp)
        {
            if (_cache.TryGetValue(email, out string storedOtp) && storedOtp == otp)
            {
                _cache.Remove(email);

                var token = _tokenHelper.GenerateAccessToken(email);

                return Ok(new { Token = token });
            }

            return StatusCode(401, new ResponseVM
            {
                Status = false,
                Message = "Mã xác thực không hợp lệ!",
            });
        }
        [Authorize("guest")]
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPassword_DTO model)
        {
            try
            {
                var result = await _accountService.ForgotPasswordAsync(model);
                return Ok(result );
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }
    }
}
