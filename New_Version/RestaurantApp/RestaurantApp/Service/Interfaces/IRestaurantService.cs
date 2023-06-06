using RestaurantApp.BOLayer;
using System;
using System.Collections.Generic;


namespace RestaurantApp.ServiceLayer.Interfaces
{
    public interface IRestaurantService
    {
            List<Restaurant> GetAllRestaurants();
            bool IsAnyResturantExist();
            List<Food> GetRestaurantMenu(Guid restaurantGuid);
            Guid SaveOrder(Order order);
            Order GetOrder(Guid orderGuid);
    }
}
