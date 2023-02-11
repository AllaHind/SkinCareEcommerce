using SkinCareEcommerce.Service.ProductAPI.Models;
using SkinCareEcommerce.Service.ProductAPI.Models.Dto;
using AutoMapper;

namespace SkinCareEcommerce.Service.ProductAPI
{
    public class MappingConfig
    {public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(
                config =>
                {
                    config.CreateMap<ProductDto, Product>();
                    config.CreateMap<Product, ProductDto>();
                }
                
                
                
                
                );
            return mappingConfig;
        }
    }
}
