using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public class Restaurant : BaseEntity
    {
        public string RestaurantName { get; set; }
        public string RestaurantPossessor { get; set; }
        public int OpenTime { get; set; }
        public int Closetime { get; set; }
        public string Address { get; set; }
        public List<Food> Menu { get; set; }
        public string PhoneNumber { get; set; }
    }
}
