using Domain.DataInterfaces;
using System;

namespace Domain.Models
{
    public class Invoice : IBaseEntity
    {
        public Guid Guid { get; set; }
        public Guid RestaurantGuid { get; set; }
        public decimal InvoiceAmount { get; set; }
    }
}
