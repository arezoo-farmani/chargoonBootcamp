using System;
using System.Collections.Generic;
using Repository;
using Domain.Models;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;
using Domain.ViewModels;
using System.Linq;

namespace Service
{
    public class FoodService : BaseService, IFoodService
    {
        private IRepository<Food> _repository;

        public FoodService()
        {
            this._repository = new DataRepository<Food>();
        }

        public List<Food> GetAllRestaurantFoods(Guid restaurantGuid)
        {
            return _repository.GetAll().FindAll(food => food.RestaurantGuid == restaurantGuid);
        }

        public void Update(Food food)
        {
            _repository.Update(food);
        }

        public List<FoodListViewModel> GetRestaurantMenu(Guid restaurantGuid)
        {
            return GetAllRestaurantFoods(restaurantGuid).Select(item =>
            (new FoodListViewModel
            {
                FoodName = item.FoodName,
                FoodPrice = item.Price,
            }
            ))?.ToList();
        }
    }
}
