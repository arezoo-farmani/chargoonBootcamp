using Domain.DataInterfaces;
using System;

namespace Domain.Models
{
    public class RestaurantList : IBaseEntity
    {
        public Guid Guid { get; set; }
        public string RestaurantName { get; set; }
    }
}
