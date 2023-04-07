using Microsoft.AspNetCore.Mvc;
using MultiplePublisher.Business.Services;

namespace MultiplePublisher.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WoocommerceController : ControllerBase
    {
        private IWoocommerceService _wcs;
        public WoocommerceController(IWoocommerceService wcs)
        {
            _wcs = wcs;
        }

        [HttpGet]
        [Route("GetProducts/{idClient}")]
        public string GetProducts(int idClient)
        {
            //No uso DTOs porque este controlador en principio es para probar
            return _wcs.GetProducts(idClient);
        }

        [HttpGet]
        [Route("Test")] //no defino los parámetros para probar con parámetros comunes por url
        public string Test(int idClient)
        {
            return "TEST usando parámetros http por url";
        }
    }
}
