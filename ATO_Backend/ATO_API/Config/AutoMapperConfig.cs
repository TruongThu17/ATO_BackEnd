using AutoMapper;
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

                
            });

            return mapperConfig.CreateMapper();
        }
    }
}