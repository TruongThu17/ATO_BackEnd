using Data.DTO.Request;
using Data.DTO.Respone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Service.ShippingSer.ShippingService;

namespace Service.ShippingSer
{
    public interface IShippingService
    {
        Task<ShippingOrderResponse> CreateShippingOrder(ShippingOrderRequest request);
        Task<ShippingTrackingResponse> TrackShippingOrder(string orderCode);
    }
}
