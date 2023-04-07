using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePublisher.Business.Services
{
    public class WoocommerceService : IWoocommerceService
    {
        public string GetProducts(int idClient)
        {
            return "TEST GetProducts()";
        }
    }
}
