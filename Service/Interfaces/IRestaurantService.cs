using Repository.Models;
using System;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface IRestaurantService
    {
        Guid SaveRestaurant(Restaurant restaurant);
        List<RestaurantList> GetAllRestaurants();
        bool IsAnyRestaurantExist();
        List<Food> GetRestaurantMenu(Guid restaurantGuid);
    }
}
