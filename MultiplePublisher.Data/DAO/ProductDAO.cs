using Microsoft.EntityFrameworkCore;
using MultiplePublisher.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePublisher.Data.DAO
{
    public class ProductDAO:BaseDAO
    {
        public Product? GetProduct(int idProduct)
        {
            return entities.Products.Where(x => x.IdProduct == idProduct).FirstOrDefault();
        }

        public void TestSP()
        {
            //entities.Database.ExecuteSqlRaw();
            //entities.Products.FromSql("usp_GetProductByName @p0", productName).FirstOrDefaultAsync();
        }
    }
}
