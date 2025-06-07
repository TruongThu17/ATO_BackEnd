using Data.DTO;
using Data.DTO.Respone;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.DashboardSer;
using Service.ProductSer;

namespace ATO_API.Controllers;

[Route("api/general")]
[ApiController]
public class GeneralController(IGeneralService service, IDashboardService dashboardService, IProductService productService) : ControllerBase
{

    [HttpGet("{tourId}")]
    public async Task<IActionResult> GetTourInfo(Guid tourId)
    {
        var data = await service.GetTourAsync(tourId);
        return Ok(data);
    }

    [HttpGet("tourist/{tourId}")]
    public async Task<IActionResult> GetTourist(Guid tourId)
    {
        var data = await service.GetTouristAsync(tourId);
        return Ok(data);
    }

    [HttpPut("{tourId}/{location}")]
    public async Task<IActionResult> UpdateLocation(Guid tourId, string location)
    {
        await service.UpdateLocationAsync(tourId, location);
        return Ok();
    }

    [HttpGet("ocop-notification")]
    public async Task<IActionResult> GetOCOPNotifications()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        var ocops = await productService.GetListOCOPSells_AFTO(Guid.Parse(userId!));

        var notifications = ocops.Where(x => x.SellVolume <= 30)
            .Select(x => new Notification($"Đợt bán OCOP sắp hết hàng cho sản phẩm {x.Product!.ProductName}"))
            .ToList();

        var expirationNotifications = ocops.Where(x => x.ExpiryDate.HasValue && x.ExpiryDate.Value.AddDays(7) >= DateTime.Now)
           .Select(x => new Notification($"Đợt bán OCOP sắp hạn cho sản phẩm {x.Product!.ProductName}"))
           .ToList();

        notifications.AddRange(expirationNotifications);
        return Ok(notifications);
    }
}
