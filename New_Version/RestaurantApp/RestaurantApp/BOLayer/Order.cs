﻿using System;
using System.Collections.Generic;

namespace RestaurantApp.BOLayer
{
    public class Order : BaseEntity
    {
        public Guid UserGuid { get; set; }
        public Guid RestaurantGuid { get; set; }
        public decimal TotalOrderAmount { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}