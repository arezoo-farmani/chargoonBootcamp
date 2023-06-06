using System;
using System.Collections.Generic;
using RestaurantApp.ServiceLayer.Interfaces;
using RestaurantApp.BOLayer;
using RestaurantApp.RepositoryLayer;
using RestaurantApp.RepositoryLayer.Interfaces;

namespace RestaurantApp.ServiceLayer
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _repository;

        public OrderService()
        {
            this._repository = new DataRepository<Order>();
        }
        public Guid SaveOrder(Order order)
        {
            order.Guid = Guid.NewGuid();
            order.TotalOrderAmount = GetTotalAmountOfOrder(order.OrderDetails);
            return _repository.Save(order);
        }

        public Order GetOrder(Guid orderGuid)
        {
            return _repository.GetByGuid(orderGuid);
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
