﻿using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Service.AccountSer;
using Service.DriverSer;
using Service.OrderSer;
using Service.ShippingSer;
using Service.VnPaySer;
using StackExchange.Redis;
using System.Net.Http;
using System.Text;
using System.Transactions;
using static Service.ShippingSer.ShippingService;

namespace ATO_API.Controllers.Tourist
{
    [Route("api/tourist/order")]
    [ApiController]
    [Authorize(Roles = "Tourists")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IConnectionMultiplexer _redis;
        private readonly IMapper _mapper;
        private readonly IVnPayService _vnPayService;
        private readonly IConfiguration _configuration;
        private readonly IShippingService _shippingService;
        public OrderController(
            IMapper mapper,
            IOrderService orderService,
            IConnectionMultiplexer redis,
            IVnPayService vnPayService,
            IConfiguration configuration,
            IShippingService shippingService
           )
        {
            _mapper = mapper;
            _orderService = orderService;
            _redis = redis;
            _vnPayService = vnPayService;
            _configuration = configuration;
            _shippingService = shippingService;
        }
        [HttpGet("get-list-orders")]
        [ProducesResponseType(typeof(List<OrderRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDrivers()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _orderService.ListOrders(Guid.Parse(userId));
                var responseResult = _mapper.Map<List<OrderRespone>>(response);


                return Ok(responseResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = ex.Message,
                });
            }
        }
        [HttpGet("get-order/{OrderId}")]
        [ProducesResponseType(typeof(OrderRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDriver(Guid OrderId)
        {
            try
            {
                var response = await _orderService.GetOrderDetails(OrderId);
                var responseResult = _mapper.Map<OrderRespone>(response);
                return Ok(responseResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = ex.Message,
                });
            }
        }
        [HttpPost("add-order")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddOrder([FromBody] OrderRequest OrderRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var responseResult = _mapper.Map<Data.Models.Order>(OrderRequest);
                responseResult.CustomerId = Guid.Parse(userId);
                var response = await _orderService.AddOrder(responseResult);
                if (OrderRequest.PaymentType == PaymentType.Transfer)
                {
                    decimal fee = (decimal)response.TotalAmount;
                    DateTime timecreate = DateTime.UtcNow;

                    var paymentUrl = await _vnPayService.CreatePaymentUrlAsync(HttpContext, response.OrderId, fee, timecreate, TypePayment.OrderPayment);
                    return Ok(paymentUrl);
                }
                else
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Tạo đơn thành công!",
                    });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = ex.Message,
                });
            }
        }
        [HttpGet("return_order")]
        public async Task<IActionResult> VNPayReturnAsync()
        {
            try
            {
                var queryParams = Request.Query;
                var checkResponse =await _vnPayService.PaymentExecute(queryParams);
                await _orderService.AddOrderPayment(checkResponse);
                var queryString = new StringBuilder();
                foreach (var param in queryParams)
                {
                    var encodedValue = Uri.EscapeDataString(param.Value);
                    queryString.Append($"{param.Key}={encodedValue}&");
                }
                string returnUrl = _configuration.GetValue<string>("VNPaySettings:ReturnUrl");
                return Redirect($"{returnUrl}?{queryString}");
            }
            catch (Exception)
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }
       
        [HttpPost("add-to-cart")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddToCart([FromBody] OrderDetail_Cart orderDetail)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (userId == null) return Unauthorized();

                await _orderService.AddToCart(Guid.Parse(userId), orderDetail);
                return Ok(new { Message = "Thêm vào giỏ hàng thành công!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }
        [HttpGet("get-cart")]
        [ProducesResponseType(typeof(List<OrderDetail_Cart_Respone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCart()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (userId == null) return Unauthorized();

                var cart = await _orderService.GetCart(Guid.Parse(userId));
                return Ok(cart);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }
        [HttpPost("refund-order/{orderId}")]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RefundOrder(Guid orderId)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (userId == null) return Unauthorized();

                var order = await _orderService.GetOrderDetails(orderId);
                if (order == null)
                {
                    return NotFound(new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy đơn hàng!"
                    });
                }

                if (order.CustomerId != Guid.Parse(userId))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Bạn không có quyền hoàn tiền đơn hàng này!"
                    });
                }

                var successfulPayment = order.VNPayPaymentResponses?
                    .FirstOrDefault(x => x.TransactionStatus == "00");

                if (successfulPayment == null)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy giao dịch thanh toán hợp lệ!"
                    });
                }
                string returnUrl = _configuration.GetValue<string>("VNPaySettings:RefundUrl");
                var refundResult = await _vnPayService.ProcessRefundAsync(
                    successfulPayment,
                    (decimal)order.TotalAmount,
                    order.OrderId.ToString(),
                    returnUrl
                );

                if (!refundResult.Success)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Hoàn tiền thất bại. Vui lòng thử lại sau!"
                    });
                }
                var PaymentStatus = refundResult.Success ? 3:2;
                await _orderService.UpdateOrderStatus(orderId, PaymentType.Refunded, PaymentStatus, StatusOrder.Canceled);
                await _orderService.AddOrderPayment(refundResult.Response);
                return Ok(new ResponseVM
                {
                    Status = true,
                    Message = "Hoàn tiền thành công!"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi trong quá trình hoàn tiền: " + ex.Message
                });
            }
        }
        [HttpGet("provinces")]
        [ProducesResponseType(typeof(ProvinceResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProvinces()
        {
            try
            {
                var provinces = await _shippingService.GetProvinces();
                return Ok(provinces);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }

        [HttpGet("districts/{provinceId}")]
        [ProducesResponseType(typeof(DistrictResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDistricts(int provinceId)
        {
            try
            {
                var districts = await _shippingService.GetDistricts(provinceId);
                return Ok(districts);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }

        [HttpGet("wards/{districtId}")]
        [ProducesResponseType(typeof(WardResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetWards(int districtId)
        {
            try
            {
                var wards = await _shippingService.GetWards(districtId);
                return Ok(wards);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }
        [HttpPost("calculate-shipping-fee")]
        [ProducesResponseType(typeof(ShippingFeeResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CalculateShippingFee([FromBody] ShippingFeeRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Request body cannot be null" });
                }

                // Validate required fields
                if (string.IsNullOrEmpty(request.ToWardCode) || request.ToDistrictId <= 0)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "ToWardCode and ToDistrictId are required" });
                }

                // Validate dimensions and weight
                if (request.Weight <= 0 || request.Length <= 0 || request.Width <= 0 || request.Height <= 0)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Invalid package dimensions or weight" });
                }

                // Validate insurance value (max 5,000,000 VND according to GHN)
                if (request.InsuranceValue > 5000000)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Insurance value cannot exceed 5,000,000 VND" });
                }

                var fee = await _shippingService.CalculateShippingFee(request);
                return Ok(fee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = $"Calculate shipping fee failed: {ex.Message}" });
            }
        }

        [HttpPost("create-shipping")]
        [ProducesResponseType(typeof(ShippingOrderResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateShipping([FromBody] ShippingOrderRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Request body cannot be null" });
                }

                // Validate required fields according to GHN API
                if (string.IsNullOrEmpty(request.from_name) ||
                    string.IsNullOrEmpty(request.from_phone) ||
                    string.IsNullOrEmpty(request.from_address) ||
                    string.IsNullOrEmpty(request.from_ward_name) ||
                    string.IsNullOrEmpty(request.from_district_name) ||
                    string.IsNullOrEmpty(request.from_province_name) ||
                    string.IsNullOrEmpty(request.to_name) ||
                    string.IsNullOrEmpty(request.to_phone) ||
                    string.IsNullOrEmpty(request.to_address) ||
                    string.IsNullOrEmpty(request.to_ward_code) ||
                    request.to_district_id <= 0)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Missing required shipping information" });
                }

                // Validate items
                if (request.items == null || !request.items.Any())
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Order must contain at least one item" });
                }

                // Validate weight and dimensions
                if (request.weight <= 0 || request.length <= 0 || request.width <= 0 || request.height <= 0)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Invalid package dimensions or weight" });
                }

                // Validate insurance value (max 10,000,000 VND according to GHN)
                if (request.insurance_value > 10000000)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Insurance value cannot exceed 10,000,000 VND" });
                }

                var shipping = await _shippingService.CreateShippingOrder(request);
                return Ok(shipping);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = $"Create shipping order failed: {ex.Message}" });
            }
        }

        [HttpGet("track-shipping/{orderCode}")]
        [ProducesResponseType(typeof(ShippingTrackingResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> TrackShipping(string orderCode)
        {
            try
            {
                var tracking = await _shippingService.TrackShippingOrder(orderCode);
                return Ok(tracking);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }

    }
}
