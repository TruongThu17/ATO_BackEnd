using Data.DTO.Respone;
using Data.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.UserSupportSer
{
    public class UserSupportService : IUserSupportService
    {

        private readonly IRepository<UserSupport> _userSupportRepository;
        public UserSupportService( IRepository<UserSupport> userSupportRepository
        )
        {
            _userSupportRepository = userSupportRepository;
        }
        public async Task<ResponseVM> RequestUserSupport(UserSupport userSupport)
        {
            try
            {
                userSupport.SupportId = Guid.NewGuid();

                await _userSupportRepository.AddAsync(userSupport);
                return new ResponseVM
                {
                    Status = true,
                    Message = "Gửi yêu cầu thành công!"
                };
            }
            catch (Exception)
            {
                return new ResponseVM
                {
                    Status = false,
                    Message = "Đã sảy ra lỗi. Vui lòng thử lại sau!"
                };
            }
            
        }
    }
}
