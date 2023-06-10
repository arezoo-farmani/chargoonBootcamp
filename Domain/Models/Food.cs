using Domain.DataInterfaces;
using System;

namespace Domain.Models
{
    public class Food : IBaseEntity
    {
        public Guid Guid { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public Guid RestaurantGuid { get; set;}
    }
}
