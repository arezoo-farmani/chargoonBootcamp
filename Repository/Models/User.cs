
namespace Repository.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
