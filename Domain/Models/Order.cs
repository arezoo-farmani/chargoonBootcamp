using Domain.DataInterfaces;
using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Order : IBaseEntity
    {
        public Guid Guid { get; set; }
        public Guid UserGuid { get; set; }
        public Guid RestaurantGuid { get; set; }
        public decimal TotalOrderAmount { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
