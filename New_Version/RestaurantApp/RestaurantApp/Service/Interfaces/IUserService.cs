using RestaurantApp.BOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.ServiceLayer.Interfaces
{
    internal interface IUserService
    {
            List<User> GetAllUsers();
            void SaveAllUsers(List<User> users);
        
    }
}
