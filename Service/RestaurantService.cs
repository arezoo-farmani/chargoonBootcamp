using Repository;
using Repository.Models;
using Service.Interfaces;
using System.Collections.Generic;

namespace Service
{
    public class RestaurantService : IRestaurantService
    {
        private IRepository _repository;
      
        public RestaurantService()
        {
            this._repository = new Repository.Repository();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _repository.GetAllRestaurants();
        }

        public bool IsAnyResturantExist()
        {
            return _repository.GetAllRestaurants()?.Count > 0 ? true : false;
        }
    }
}
