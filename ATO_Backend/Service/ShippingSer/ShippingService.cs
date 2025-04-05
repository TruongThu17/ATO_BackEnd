using Data.DTO.Request;
using Data.DTO.Respone;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Service.ShippingSer
{
    public class ShippingService : IShippingService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private string _token;

        public ShippingService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _httpClient.BaseAddress = new Uri("https://partner.viettelpost.vn");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            GetTokenAsync().Wait();
        }

        private async Task GetTokenAsync()
        {
            try
            {
                var loginData = new
                {
                    username = "hoaithu1707.25@gmail.com",
                    password = "Thu@1707"
                };

                var response = await _httpClient.PostAsJsonAsync("/?uId=login", loginData);
                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Login Response: {responseContent}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Login failed: {response.StatusCode}, Content: {responseContent}");
                }

                var result = await response.Content.ReadFromJsonAsync<LoginResponse>();
                if (result?.data?.token == null)
                {
                    throw new Exception("Token not found in response");
                }

                _token = result.data.token;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Login Error: {ex.Message}");
                throw;
            }
        }



        public async Task<ShippingOrderResponse> CreateShippingOrder(ShippingOrderRequest request)
        {
            try
            {
                var orderRequest = new
                {
                    ORDER_NUMBER = "DH" + DateTime.Now.Ticks,
                    SENDER_FULLNAME = "Test Shop",
                    SENDER_ADDRESS = "123 Test Street",
                    SENDER_PHONE = "0363008467",
                    SENDER_EMAIL = "test@email.com",
                    SENDER_WARD = 550,
                    SENDER_DISTRICT = 550,
                    SENDER_PROVINCE = 550,
                    RECEIVER_FULLNAME = request.ToName,
                    RECEIVER_ADDRESS = request.ToAddress,
                    RECEIVER_PHONE = request.ToPhone,
                    RECEIVER_EMAIL = "",
                    RECEIVER_WARD = 550,
                    RECEIVER_DISTRICT = 550,
                    RECEIVER_PROVINCE = 550,
                    PRODUCT_NAME = "Test Product",
                    PRODUCT_DESCRIPTION = request.Note,
                    PRODUCT_QUANTITY = 1,
                    PRODUCT_PRICE = 100000,
                    PRODUCT_WEIGHT = request.Weight,
                    PRODUCT_LENGTH = 15,
                    PRODUCT_WIDTH = 15,
                    PRODUCT_HEIGHT = 15,
                    ORDER_PAYMENT = 1,
                    ORDER_SERVICE = "VCN",
                    ORDER_SERVICE_ADD = "",
                    ORDER_VOUCHER = "",
                    ORDER_NOTE = request.Note
                };

                var response = await _httpClient.PostAsJsonAsync("order/createOrder", orderRequest);
                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Viettel Post API Response: {responseContent}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Viettel Post API Error: {responseContent}");
                }

                return await response.Content.ReadFromJsonAsync<ShippingOrderResponse>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<ShippingTrackingResponse> TrackShippingOrder(string orderCode)
        {
            try
            {
                var response = await _httpClient.GetAsync($"order/tracking?order_number={orderCode}");
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Viettel Post Tracking API Error: {responseContent}");
                }

                return await response.Content.ReadFromJsonAsync<ShippingTrackingResponse>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tracking Error: {ex.Message}");
                throw;
            }
        }
        private class LoginResponse
        {
            public string message { get; set; }
            public string status { get; set; }
            public LoginData data { get; set; }
        }

        private class LoginData
        {
            public string token { get; set; }
            public string username { get; set; }
            public string phone { get; set; }
            public string name { get; set; }
        }

    }
        public class ShippingOrderResponse
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public OrderData Data { get; set; }
        }

        public class OrderData
        {
            public string ORDER_NUMBER { get; set; }
            public string MONEY_COLLECTION { get; set; }
            public string MONEY_TOTAL { get; set; }
            public string MONEY_TOTAL_FEE { get; set; }
            public string EXCHANGE_WEIGHT { get; set; }
            public string MONEY_FEE { get; set; }
            public string MONEY_OTHER_FEE { get; set; }
            public string MONEY_VAT { get; set; }
            public string MONEY_TOTAL_CONFIRM { get; set; }
            public string ORDER_STATUS { get; set; }
            public string ORDER_STATUS_NAME { get; set; }
            public string ORDER_DETAIL_STATUS { get; set; }
            public string ORDER_DETAIL_STATUS_NAME { get; set; }
        }

        public class ShippingTrackingResponse
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public TrackingData Data { get; set; }
        }

        public class TrackingData
        {
            public string ORDER_NUMBER { get; set; }
            public string ORDER_REFERENCE { get; set; }
            public string ORDER_STATUS { get; set; }
            public string ORDER_STATUS_NAME { get; set; }
            public List<TrackingHistory> ORDER_TRACKING { get; set; }
        }

        public class TrackingHistory
        {
            public string STATUS { get; set; }
            public string STATUS_NAME { get; set; }
            public string LOCATION { get; set; }
            public DateTime TIMESTAMP { get; set; }
            public string DESCRIPTION { get; set; }
        }
}
