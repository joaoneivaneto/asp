﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethenyPieShop2.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
