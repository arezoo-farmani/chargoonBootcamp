using Repository;
using Repository.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Service
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
