﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.SystemConfigSer
{
    public interface ISystemConfigurationsService
    {
        Task<bool> UpdateEmailAndAppPasswordAsync(string email, string appPassword);
    }

}
