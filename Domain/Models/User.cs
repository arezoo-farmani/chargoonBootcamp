
using Domain.DataInterfaces;
using System;

namespace Domain.Models
{
    public class User : IBaseEntity
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
