﻿using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AccountSer
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAllAccountsAsync();
        Task<IEnumerable<Account>> GetAccountsAsync();
        Task<Account> GetAccountByIdAsync(Guid accountId);
        Task AddAccountAsync(Account account);
        Task UpdateAccountAsync(Account account);
        Task<ResponseLogin> LoginAsync(LoginDTO model);
        Task<ResponseVM_Email> ForgotPasswordSendOTPAsync(string email);
        Task<ResponseVM> ForgotPasswordAsync(ForgotPassword_DTO model);
        Task<bool> ResetPasswordAsync(Guid id, string newPassword);
        Task<bool> InactiveAccountAsync(Guid id);
        Task<Account?> GetAccountByPhoneNumberAsync(string phoneNumber);
        Task<IEnumerable<Account>> GetUnassignedTourCompaniesAsync();
        Task<IEnumerable<Account>> GetUnassignedTouristFacilitiesAsync();
        Task<IEnumerable<Account>> GetGuideTeamsAsync(Guid UserId);
        Task<bool> AnyAccountByEmailAsync(string email);
        Task<bool> AnyAccountByUsernameAsync(string username);
        Task<bool> AnyAccountByPhoneAsync(string phone);
        Task<ResponseModel> ChangePassword(string? id, string currentPassword, string password);
    }
}
