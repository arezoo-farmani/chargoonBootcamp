using System;
using Domain.Models;

namespace Domain.ServiceInterfaces
{
    public interface IOrderService
    {
        Guid Save(Order order);
        Order Get(Guid orderGuid);
    }
}
