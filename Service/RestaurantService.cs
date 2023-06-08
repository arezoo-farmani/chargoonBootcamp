using Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;

namespace Service
{
    public class RestaurantService : IRestaurantService
    {
        private IRepository<Restaurant> _repository;

        public RestaurantService()
        {
            this._repository = new DataRepository<Restaurant>();
        }

        public List<RestaurantList> GetAll()
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

        public Guid Save(Restaurant restaurant)
        {
            restaurant.Guid = Guid.NewGuid();
            return _repository.Save(restaurant);
        }

    }
}
