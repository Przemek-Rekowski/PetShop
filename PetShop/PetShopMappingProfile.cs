using AutoMapper;
using PetShopAPI.Entities;
using PetShopAPI.Models;
using System;

namespace PetShopAPI
{
    public class PetShopMappingProfile : Profile
    {
        public PetShopMappingProfile()
        {
            CreateMap<CreateProductDto, Product>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid().ToString()));

            CreateMap<UpdateProductDto, Product>()
                .ReverseMap();
        }
    }
}
