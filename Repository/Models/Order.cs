using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public class Order
    {
        public Guid Guid { get; set; }
        public Guid UserGuid { get; set; }
        public Guid RestaurantGuid { get; set; }
        public decimal TotalOrderAmount { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
