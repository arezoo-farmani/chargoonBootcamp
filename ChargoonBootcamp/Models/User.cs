using System;

namespace ResturantApp
{
    class User
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public void ValidatePhoneNumber()
        {
            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                Console.WriteLine("PhoneNumber is mandatory");
            }

        }
    }
}
