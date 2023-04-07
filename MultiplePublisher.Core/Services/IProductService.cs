﻿using MultiplePublisher.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePublisher.Core.Services
{
    public interface IProductService
    {
        ProductResponse GetProduct(ProductRequest req);
    }
}
