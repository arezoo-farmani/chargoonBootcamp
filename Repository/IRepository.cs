using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using ResturantApp;

namespace Repository
{
    public interface IRepository
    {
        List<User> GetAllUsers();
        void SaveAllUsers(List<User> users);
        List<Restaurant> GetAllRestaurants();
        void SaveAllRestaurants(List<Restaurant> restaurants);
    }
}
