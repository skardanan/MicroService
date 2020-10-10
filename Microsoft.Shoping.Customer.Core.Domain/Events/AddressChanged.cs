using MicroService.Shoping.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Shoping.Customers.Domain.Events
{
    public class AddressChanged : IDomainEvent
    {
        public AddressChanged(string addressId, string country, string city, string street)
        {
            AddressId = addressId;
            Country = country;
            City = city;
            Street = street;
        }
        public string AddressId { get; }
        public string Country { get; }
        public string City { get; }
        public string Street { get; }
    }
}
