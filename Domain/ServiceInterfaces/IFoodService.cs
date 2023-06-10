using System;
using System.Collections.Generic;
using Domain.Models;
using Domain.ViewModels;

namespace Domain.ServiceInterfaces
{
    public interface IFoodService : IBaseService
    {
        List<Food> GetAllRestaurantFoods(Guid restaurantGuid);
        void Update(Food food);
        List<FoodListViewModel> GetRestaurantMenu(Guid restaurantGuid);
    }
}
