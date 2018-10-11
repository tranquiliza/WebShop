using System;

namespace WebShop.Models.Customers
{
    public class Customer : Entity
    {
        public string FirstName { get; private set; }
        public string Surname { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        public string Zip { get; private set; }
        public string Country { get; private set; }
        public string PhoneNumber { get; private set; }

        private Customer() { }

        public Customer(string firstName, string surname, string address, string email, string zip, string country, string phoneNumber)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Zip = zip ?? throw new ArgumentNullException(nameof(zip));
            Country = country ?? throw new ArgumentNullException(nameof(country));
            PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
        }
    }
}
