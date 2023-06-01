using System;
using System.Collections.Generic;
using UI;

namespace ResturantApp
{
   public class Restaurant
    {
        public string RestaurantName { get; set; }
        public string RestaurantPossessor { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime Closetime { get; set; }
        public string Address { get; set; }
        public List<Food> Menu { get; set; }
    }
}
