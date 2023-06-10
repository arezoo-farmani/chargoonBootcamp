using Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;
using Domain.ViewModels;

namespace Service
{
    public class RestaurantService : BaseService, IRestaurantService
    {
        private IRepository<Restaurant> _repository;

        public RestaurantService()
        {
            this._repository = new DataRepository<Restaurant>();
        }

        public List<RestaurantListViewModel> GetAll()
        {
            return _repository.GetAll().Select(item =>
            (new RestaurantListViewModel
            {
                Guid = item.Guid,
                RestaurantName = item.RestaurantName
            }
            ))?.ToList();
        }
    }
}
