using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiplePublisher.Common.DTOs;
using MultiplePublisher.Business.Services;

namespace MultiplePublisher.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _ps;

        public ProductController(IProductService ps)
        {
            _ps = ps;
        }

        // GET: ProductController/GetProduct/1
        [HttpGet]
        [Route("GetProduct/{idProduct}")]
        public ProductResponse GetProduct(int idProduct)
        {
            ProductRequest req = new ProductRequest { IdProduct = idProduct };

            return _ps.GetProduct(req);
        }
    }
}
