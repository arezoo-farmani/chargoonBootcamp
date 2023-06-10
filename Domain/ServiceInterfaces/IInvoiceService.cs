using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;

namespace Domain.ServiceInterfaces
{
    public interface IInvoiceService: IBaseService
    {
        List<InvoiceListViewModel> GetAllRestaurantInvoces(Guid reastaurantGuid);
    }
}
