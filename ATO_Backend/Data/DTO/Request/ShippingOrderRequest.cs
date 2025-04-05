using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class ShippingOrderRequest
    {
        public string FromName { get; set; } = "ATO Shop";
        public string FromPhone { get; set; }
        public string FromAddress { get; set; }
        public string FromWardName { get; set; }
        public string FromDistrictName { get; set; }
        public string FromProvinceName { get; set; }

        public string ToName { get; set; }
        public string ToPhone { get; set; }
        public string ToAddress { get; set; }
        public string ToWardName { get; set; }
        public string ToDistrictName { get; set; }
        public string ToProvinceName { get; set; }

        public int Weight { get; set; }
        public int Length { get; set; } = 15;
        public int Width { get; set; } = 15;
        public int Height { get; set; } = 15;

        public string Note { get; set; }
        public int PaymentTypeId { get; set; } = 2;
        public int ServiceTypeId { get; set; } = 2;
        public string RequiredNote { get; set; } = "KHONGCHOXEMHANG";
    }
}
