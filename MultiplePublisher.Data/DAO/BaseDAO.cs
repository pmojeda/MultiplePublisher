using MultiplePublisher.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MultiplePublisher.Data.DAO
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
