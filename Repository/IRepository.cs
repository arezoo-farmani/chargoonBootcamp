using Repository.Models;
using System;
using System.Collections.Generic;


namespace Repository
{
    public interface IRepository
    {
        List<User> GetAllUsers();
        void SaveAllUsers(List<User> users);
        List<Restaurant> GetAllRestaurants();
        void SaveAllRestaurants(List<Restaurant> restaurants);
        Guid SaveOrder(Order order);
        Order GetOrder(Guid orderGuid);
    }
}
