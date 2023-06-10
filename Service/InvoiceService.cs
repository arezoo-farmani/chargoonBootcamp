using Domain.Models;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;
using Domain.ViewModels;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
    public class InvoiceService : BaseService, IInvoiceService
    {
        private IRepository<Invoice> _repository;

        public InvoiceService()
        {
            this._repository = new DataRepository<Invoice>();
        }

        public List<InvoiceListViewModel> GetAllRestaurantInvoces(Guid restaurantGuid)
        {
            int counter = 1;
            List<InvoiceListViewModel> list = new List<InvoiceListViewModel>();
            foreach (var item in this._repository.GetAll())
            {
                if (item.RestaurantGuid == restaurantGuid)
                {
                    list.Add(new InvoiceListViewModel
                    {
                        InvoiceName = $"فاکتور {counter++}",
                        Amount = item.InvoiceAmount,
                    });
                }
            }
            return list;
        }

    }
}
