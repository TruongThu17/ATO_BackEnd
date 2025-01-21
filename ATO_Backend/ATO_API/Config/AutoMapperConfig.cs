using AutoMapper;
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
                config.CreateMap<Blog, ListBlog_Guest_DTO>()
                .ForMember(dest => dest.TouristFacilityId, opt => opt.MapFrom(src => src.Account.TouristFacility.TouristFacilityId))
                .ForMember(dest => dest.TourCompanyId, opt => opt.MapFrom(src => src.Account.TourCompany.TourCompanyId))
                 .ForMember(dest => dest.CreateByName, opt => opt.MapFrom(src =>
                    src.Account.TourCompany != null ? src.Account.TourCompany.CompanynName :
                    src.Account.TouristFacility != null ? src.Account.TouristFacility.TouristFacilityName : "Hệ thống ATOS"
                ));
                config.CreateMap<Blog, Blog_Guest_DTO>()
                .ForMember(dest => dest.TouristFacilityId, opt => opt.MapFrom(src => src.Account.TouristFacility.TouristFacilityId))
                .ForMember(dest => dest.TourCompanyId, opt => opt.MapFrom(src => src.Account.TourCompany.TourCompanyId))
                 .ForMember(dest => dest.CreateByName, opt => opt.MapFrom(src =>
                    src.Account.TourCompany != null ? src.Account.TourCompany.CompanynName :
                    src.Account.TouristFacility != null ? src.Account.TouristFacility.TouristFacilityName : "Hệ thống ATOS"
                ));
            });

            return mapperConfig.CreateMapper();
        }
    }
}