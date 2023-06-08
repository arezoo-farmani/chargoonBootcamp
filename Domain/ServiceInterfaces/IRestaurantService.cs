using Domain.Models;
using System;
using System.Collections.Generic;

namespace Domain.ServiceInterfaces
{
    public interface IRestaurantService
    {
        Guid Save(Restaurant restaurant);
        List<RestaurantList> GetAll();
        bool IsAnyRestaurantExist();
        List<Food> GetRestaurantMenu(Guid restaurantGuid);
    }
}
