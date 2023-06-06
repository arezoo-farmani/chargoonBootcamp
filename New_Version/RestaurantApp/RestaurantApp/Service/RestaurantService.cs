using RestaurantApp.BOLayer;
using RestaurantApp.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantApp.ServiceLayer.Interfaces;
using RestaurantApp.RepositoryLayer.Interfaces;

namespace RestaurantApp.ServiceLayer
{
    public class RestaurantService : IRestaurantService
    {
        private DataRepository<Restaurant> _repository;

        public RestaurantService()
        {
            this._repository = new DataRepository<Restaurant>();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _repository.GetAll();
        }

        public bool IsAnyResturantExist()
        {
            return _repository.GetAll()?.Count > 0 ? true : false;
        }

        public List<Food> GetRestaurantMenu(Guid restaurantGuid)
        {
            var restaurant = _repository.GetAll()?.Find((resturant) => resturant.Guid == restaurantGuid);
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
