using System;
using System.Collections.Generic;
using Repository.Models;

namespace Service.Interfaces
{
    public interface IOrderService
    {
        Guid SaveOrder(Order order);
        Order GetOrder(Guid orderGuid);
    }
}
