﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class ResponseLogin
    {
        public string Bear { get; set; }
        public DateTime Expiration { get; set; }
        public string? Role { get; set; }
    }
}
