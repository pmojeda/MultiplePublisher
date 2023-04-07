using MultiplePublisher.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MultiplePublisher.Infrastructure.DAO
{
    public class BaseDAO
    {
        public MultiplePublisherContext entities;

        public BaseDAO()
        {
            entities = new MultiplePublisherContext();
        }
    }
}
