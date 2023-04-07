using AutoMapper;
using MultiplePublisher.Common.DTOs;
using MultiplePublisher.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePublisher.Core.Mappers
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            //CreateMap<ProductResponse, Product>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description)).ForMember(dest => dest.IdProduct, opt => opt.Ignore());
            CreateMap<Product, ProductResponse>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        }
    }
}
