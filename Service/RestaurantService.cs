using Repository;
using Repository.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class RestaurantService : IRestaurantService
    {
        private IRepository<Restaurant> _repository;

        public RestaurantService()
        {
            this._repository = new DataRepository<Restaurant>();
        }

        public List<RestaurantList> GetAllRestaurants()
        {
            return _repository.GetAll().Select(item =>
            (new RestaurantList
            {
                Guid = item.Guid,
                RestaurantName = item.RestaurantName
            }
            ))?.ToList();
        }

        public bool IsAnyRestaurantExist()
        {
            return _repository.GetAll()?.Count > 0 ? true : false;
        }

        public List<Food> GetRestaurantMenu(Guid restaurantGuid)
        {
            var restaurant = _repository.GetAll()?.Find((resturant) => resturant.Guid == restaurantGuid);
            return restaurant.Menu;
        }

        public Guid SaveRestaurant(Restaurant restaurant)
        {
            restaurant.Guid = Guid.NewGuid();
            return _repository.Save(restaurant);
        }

    }
}
