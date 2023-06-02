using Repository.Models;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface IRestaurantService
    {
        List<Restaurant> GetAllRestaurants();
        bool IsAnyResturantExist();

    }
}
