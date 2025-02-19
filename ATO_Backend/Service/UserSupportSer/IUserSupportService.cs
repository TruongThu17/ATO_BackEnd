using Data.DTO.Respone;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.UserSupportSer
{
    public interface IUserSupportService
    {
        Task<ResponseVM> RequestUserSupport(UserSupport userSupport);
    }
}
