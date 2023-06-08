using Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;

namespace Service
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _repository;

        public OrderService()
        {
            this._repository = new DataRepository<Order>();
        }
        public Guid Save(Order order)
        {
            order.Guid = Guid.NewGuid();
            order.TotalOrderAmount = GetTotalAmountOfOrder(order.OrderDetails);
            return _repository.Save(order);
        }

        public Order Get(Guid orderGuid)
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
