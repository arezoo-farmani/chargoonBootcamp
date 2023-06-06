using System;
using RestaurantApp.BOLayer;

namespace RestaurantApp.ServiceLayer.Interfaces
{
    public interface IOrderService
    {
        Guid SaveOrder(Order order);
        Order GetOrder(Guid orderGuid);
    }
}
