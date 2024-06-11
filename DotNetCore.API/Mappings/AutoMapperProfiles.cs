using AutoMapper;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Models.DTOs;

namespace DotNetCore.API.Mappings
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        { 
            CreateMap<Region, RegionDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();

            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<AddCategoryRequestDto, Category>().ReverseMap();
            CreateMap<AddProductRequestDto, Product>().ReverseMap();

            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateCategoryRequestDto, Category>().ReverseMap();
            CreateMap<UpdateProductRequestDto, Product>().ReverseMap();
        }
    }
}
