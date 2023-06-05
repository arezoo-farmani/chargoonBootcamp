using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Restaurant
    {
        public Guid Guid { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantPossessor { get; set; }
        public decimal OpenTime { get; set; }
        public decimal Closetime { get; set; }
        public string Address { get; set; }
        public List<Food> Menu { get; set; }
        public string PhoneNumber { get; set; }
    }
}
