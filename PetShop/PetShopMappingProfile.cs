using AutoMapper;
using PetShopAPI.Entities;
using PetShopAPI.Models;

namespace PetShopAPI
{
    public class PetShopMappingProfile : Profile
    {
        public PetShopMappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name));

            CreateMap<CreateProductDto, Product>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<UpdateProductDto, Product>().ReverseMap();

            CreateMap<Cart, CartDto>();
        }
    }
}
