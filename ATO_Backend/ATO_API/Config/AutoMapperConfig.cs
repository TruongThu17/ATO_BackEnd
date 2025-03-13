﻿using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using System.ComponentModel;
using System.Reflection;

namespace ATO_API.Config
{
    public class AutoMapperConfig : Profile
    {
        public static IMapper Initialize()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                // blog mapper
                config.CreateMap<Blog, Blog_Guest_DTO>()
                .ForMember(dest => dest.TouristFacilityId, opt => opt.MapFrom(src => src.Account.TouristFacility.TouristFacilityId))
                .ForMember(dest => dest.TourCompanyId, opt => opt.MapFrom(src => src.Account.TourCompany.TourCompanyId))
                 .ForMember(dest => dest.CreateByName, opt => opt.MapFrom(src =>
                    src.Account.TourCompany != null ? src.Account.TourCompany.CompanynName :
                    src.Account.TouristFacility != null ? src.Account.TouristFacility.TouristFacilityName : "Hệ thống ATOS"
                ));
                config.CreateMap<Blog, Blog_CM_DTO>()
                .ForMember(dest => dest.TouristFacilityId, opt => opt.MapFrom(src => src.Account.TouristFacility.TouristFacilityId))
                .ForMember(dest => dest.TourCompanyId, opt => opt.MapFrom(src => src.Account.TourCompany.TourCompanyId))
                 .ForMember(dest => dest.CreateByName, opt => opt.MapFrom(src =>
                    src.Account.TourCompany != null ? src.Account.TourCompany.CompanynName :
                    src.Account.TouristFacility != null ? src.Account.TouristFacility.TouristFacilityName : "Hệ thống ATOS"
                ));
                config.CreateMap<BlogCreateRequest, Blog>();
                config.CreateMap<BlogUpdateRequest, Blog>();
                // user support
                config.CreateMap<UserSupportRequest, UserSupport>();
                config.CreateMap<UserSupport, UserSupportDetails>()
                .ForMember(dest => dest.ResponeBy, opt => opt.MapFrom(src => src.ResponeAccount.Fullname))
                .ForMember(dest => dest.IssueTypeDescription, opt => opt.MapFrom(src => GetEnumDescription(src.IssueType)));
                // manage users 
                config.CreateMap<Account, UserRespone>();
                config.CreateMap<Account, UserUnassignedTourCompany>();
                config.CreateMap<TourCompany, UserRespone_TourCompany>();
                config.CreateMap<TouristFacility, UserRespone_TouristFacility>();
                config.CreateMap<TourGuide, UserRespone_TourGuide>();
                config.CreateMap<CreateAccountRequest, Account>();
                // TouristFacility
                config.CreateMap<TouristFacility, TouristFacilityDTO>();
                config.CreateMap<Account, TouristFacilityDTO_UserRespone>();
                config.CreateMap<CreateTouristFacilityRequest, TouristFacility>();
                config.CreateMap<UpdateTouristFacilityRequest, TouristFacility>();
                // TourCompany
                config.CreateMap<TourCompany, TourCompanyDTO>();
                config.CreateMap<Account, TourCompanyDTO_UserRespone>();
                config.CreateMap<CreateTourCompanyRequest, TourCompany>();
                // product
                config.CreateMap<Product, ProductDTO>();
                config.CreateMap<CreateProductDTO, Product>();
                config.CreateMap<UpdateProductDTO, Product>();
                // OCOPSell
                config.CreateMap<OCOPSell, OCOPSellDTO>();
                config.CreateMap<CreateOCOPSellDTO, OCOPSell>();
                config.CreateMap<UpdateOCOPSellDTO, OCOPSell>();
            });

            return mapperConfig.CreateMapper();
        }
        public static string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = field?.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? value.ToString();
        }
    }
}

