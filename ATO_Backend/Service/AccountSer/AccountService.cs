﻿using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Service.EmailSer;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.AccountSer
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<Account> _accountRepository;
        private readonly UserManager<Account> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        private readonly IMemoryCache _cache;
        private readonly TimeSpan _otpLifetime = TimeSpan.FromMinutes(5);
        public AccountService(
            IRepository<Account> accountRepository,
            UserManager<Account> userManager,
            IConfiguration configuration,
            IEmailService emailService,
            IMemoryCache cache
            )
        {
            _accountRepository = accountRepository;
            _userManager = userManager;
            _configuration = configuration;
            _emailService = emailService;
            _cache = cache;
        }
        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            return await _accountRepository.GetAllAsync();
        }

        public async Task<Account> GetAccountByIdAsync(Guid id)
        {
            return await _accountRepository.GetByIdAsync(id);
        }

        public async Task AddAccountAsync(Account account)
        {
            await _accountRepository.AddAsync(account);
        }

        public async Task UpdateAccountAsync(Account account)
        {
            await _accountRepository.UpdateAsync(account);
        }
        // hàm đăng nhập
        public async Task<ResponseLogin> LoginAsync(LoginDTO model)
        {
            try
            {
                // Tìm user trong hệ thống
                var user = await _userManager.Users
                    .Where(u => u.UserName == model.Username)
                    .FirstOrDefaultAsync();

                // Kiểm tra nếu user không tồn tại
                if (user == null)
                {
                    throw new Exception("Tài khoản của bạn không tồn tại!");
                }

                // Kiểm tra nếu tài khoản bị khóa
                if (!user.isAccountActive)
                {
                    throw new Exception("Tài khoản của bạn đã bị khóa!");
                }

                // Kiểm tra mật khẩu
                if (!string.IsNullOrEmpty(model.Password) &&
                    !await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    throw new Exception("Sai mật khẩu đăng nhập!");
                }

                // Lấy thông tin vai trò của người dùng
                var userRoles = await _userManager.GetRolesAsync(user);
                var role = userRoles.FirstOrDefault();

                // Tạo danh sách claims cho người dùng
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
                if (!string.IsNullOrEmpty(user.AvatarURL))
                {
                    authClaims.Add(new Claim("AvatarUrl", user.AvatarURL));
                }

                // Tạo token
                var Bear = GenerateToken(authClaims);

                // Trả về kết quả
                return new ResponseLogin
                {
                    Bear = new JwtSecurityTokenHandler().WriteToken(Bear),
                    Expiration = Bear.ValidTo,
                    Role = role
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Đã sảy ra lỗi, vui lòng thử lại sau!");
            }
        }
        //hàm gen token

        private JwtSecurityToken GenerateToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var expirationTimeUtc = DateTime.UtcNow.AddHours(72);

            return new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.SpecifyKind(expirationTimeUtc, DateTimeKind.Utc),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );
        }
        // hàm gửi mã xác thực tài khoản để thay đổi mật khẩu
        public async Task<ResponseVM_Email> ForgotPasswordSendOTPAsync(string username)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(username);
                if (user == null)
                {
                    throw new Exception("Không tìm thấy tài khoản người dùng nào trùng với tên đăng nhập " + username + "!");
                }
                var otp = new Random().Next(100000, 999999).ToString();
                EmailRequest emailRequest = new EmailRequest();
                emailRequest.ToEmail = user.Email;
                emailRequest.Subject = "Mã Xác thực tài khoản người dùng";
                emailRequest.Body = $"Mã xác thực tài khoản của bạn là: {otp}";
                _cache.Set(emailRequest.ToEmail, otp, _otpLifetime);
                await _emailService.SendEmailAsync(emailRequest);

                return new ResponseVM_Email()
                {
                    Message = "Mã xác thực đã được gửi đến email của bạn!",
                    Status = true,
                    toEmail = user.Email,
                };
            }
            catch (Exception)
            {
                throw new Exception("Đã sảy ra lỗi, vui lòng thử lại sau!");

            }
        }
        // thay đổi mật khẩu khi đã xác thực thành công 
        public async Task<ResponseVM> ForgotPasswordAsync(ForgotPassword_DTO model)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(model.username);
                if (user == null)
                {
                    throw new Exception("Không tìm thấy tài khoản!");
                }
                if (!model.NewPassword.Equals(model.ConfimPassword))
                {
                    throw new Exception("Mã xác nhận không chính xác!");
                }
                if (!IsValidPassword(model.NewPassword))
                {
                    throw new Exception("Mật khẩu mới phải chứa ít nhất một ký tự in hoa, một ký tự thường, một số và một ký tự đặc biệt.");
                }

                var resetPasswordResult = await _userManager.RemovePasswordAsync(user);
                if (!resetPasswordResult.Succeeded)
                {
                    throw new Exception("Đã xảy ra lỗi, vui lòng thử lại sau!");
                }
                var user2 = await _userManager.FindByNameAsync(model.username);
                var result = await _userManager.AddPasswordAsync(user, model.NewPassword);
                if (!result.Succeeded)
                {
                    throw new Exception("Đặt lại mật khẩu không thành công!");
                }

                return new ResponseVM
                {
                    Status = true,
                    Message = "Đổi mật khẩu thành công!"
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Đặt lại mật khẩu không thành công!");
            }
        }
        // Phương thức kiểm tra mật khẩu mới
        private bool IsValidPassword(string password)
        {
            // Kiểm tra mật khẩu có ít nhất 1 ký tự in hoa, 1 ký tự thường, 1 số và 1 ký tự đặc biệt, 8 ký tự
            var passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");

            return passwordRegex.IsMatch(password);
        }
    }
}
