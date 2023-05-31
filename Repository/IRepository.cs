using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;
using WindowsFormsApp_Restaurant;

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
