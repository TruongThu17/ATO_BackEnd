using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class CreateUserSupportRequest
    {
        public IssueType IssueType { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string SupportMessage { get; set; }
    }
}
