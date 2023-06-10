using System;
using Domain.Models;

namespace Domain.ServiceInterfaces
{
    public interface IOrderService
    {
        Order Get(Guid orderGuid);
        Guid Save(Order order);
    }
}
