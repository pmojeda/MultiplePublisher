using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePublisher.Common.DTOs
{
    public class ProductResponse: ResponseBase
    {
        public int IdProduct { get; set; }
        public string Description { get; set; }

        public ProductResponse()
        {
            this.IdProduct = 0;
            this.Description = string.Empty;
        }
    }
}
