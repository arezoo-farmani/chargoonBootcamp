using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;

namespace WindowsFormsApp_Restaurant
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
