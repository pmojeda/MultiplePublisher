﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePublisher.Core.Services
{
    public interface IWoocommerceService
    {
        string GetProducts(int idClient);
    }
}
