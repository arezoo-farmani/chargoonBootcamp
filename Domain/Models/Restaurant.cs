using Domain.DataInterfaces;
using System;

namespace Domain.Models
{
    public class Restaurant : IBaseEntity, IPhoneNumber
    {
        public Guid Guid { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantPossessor { get; set; }
        public int OpenTime { get; set; }
        public int Closetime { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
