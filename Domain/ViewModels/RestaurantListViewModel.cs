using Domain.DataInterfaces;
using System;

namespace Domain.ViewModels
{
    public class RestaurantListViewModel : IBaseEntity
    {
        public Guid Guid { get; set; }
        public string RestaurantName { get; set; }
    }
}
