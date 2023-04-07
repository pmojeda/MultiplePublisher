using MultiplePublisher.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiplePublisher.Infrastructure.DAO;
using MultiplePublisher.Infrastructure.Models;
using AutoMapper;

namespace MultiplePublisher.Core.Services
{
    public class ProductService : IProductService
    {
        IMapper _mapper;
        public ProductService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public ProductResponse GetProduct(ProductRequest req)
        {
            ProductDAO dao = new ProductDAO();
            ProductResponse res = new ProductResponse();
            Product? product = dao.GetProduct(req.IdProduct);
            
            if (product != null)
            {
                res = _mapper.Map<ProductResponse>(product);
            }
         
            return res;
        }
    }
}
