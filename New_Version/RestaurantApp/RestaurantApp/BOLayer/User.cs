using RestaurantApp.BOLayer.Interfaces;

namespace RestaurantApp.BOLayer
{
    public class User : BaseEntity, IPhoneNumeber
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }        
        public string PhoneNumber { get; set; }
    }
}
