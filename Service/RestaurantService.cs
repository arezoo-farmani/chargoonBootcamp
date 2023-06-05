using Repository;
using Repository.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Service
{
    public class RestaurantService : IRestaurantService
    {
        private IRepository _repository;
      
        public RestaurantService()
        {
            this._repository = new Repository.DataRepository();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _repository.GetAllRestaurants();
        }

        public bool IsAnyResturantExist()
        {
            return _repository.GetAllRestaurants()?.Count > 0 ? true : false;
        }

        public List<Food> GetRestaurantMenu(Guid restaurantGuid)
        {
            var restaurant = _repository.GetAllRestaurants()?.Find((resturant) => resturant.Guid == restaurantGuid);
            return restaurant.Menu;
        }

        public Guid SaveOrder(Order order)
        {
            order.Guid = Guid.NewGuid();
            order.TotalOrderAmount = GetTotalAmountOfOrder(order.OrderDetails);
            return _repository.SaveOrder(order);
        }

        public Order GetOrder(Guid orderGuid)
        {
            return _repository.GetOrder(orderGuid);
        }

        private decimal GetTotalAmountOfOrder(List<OrderDetail> orderDetails)
        {
            decimal totalAmount = 0;
            orderDetails?.ForEach((detail) =>
            {
                var eachFoodAmount = detail.FoodPrice * detail.Count;
                totalAmount += eachFoodAmount;
            });
            return totalAmount;
        }
    }
}
