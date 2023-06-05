using Repository.Models;
using Service;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantApp.Controllers
{
    public class RestaurantController
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController()
        {
            this._restaurantService = new RestaurantService();
        }

        public List<RestaurantList> GetAllRestaurants()
        {
             return _restaurantService.GetAllRestaurants().Select(item => ToViewModel(item)).ToList();
        }

        public bool IsAnyResturantExit()
        {
            return _restaurantService.IsAnyResturantExist();
        }

        public List<Food> GetRestaurantMenu(Guid restaurantGuid)
        {
            return _restaurantService.GetRestaurantMenu(restaurantGuid);
        }

        private RestaurantList ToViewModel(Restaurant restaurant)
        {
            return new RestaurantList
            {
                Guid = restaurant.Guid,
                RestaurantName = restaurant.RestaurantName,
            };
        }

        public Guid SaveOrder(Order order)
        {
            return _restaurantService.SaveOrder(order);
        }
        public Order GetOrder(Guid orderGuid)
        {
            return _restaurantService.GetOrder(orderGuid);
        }

    }
}
