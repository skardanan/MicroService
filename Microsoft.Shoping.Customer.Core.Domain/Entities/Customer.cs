using MicroService.Shoping.Customer.Domain.Events;
using MicroService.Shoping.Customer.Domain.ValueObjects;
using MicroService.Shoping.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Shoping.Customer.Domain.Entities
{
    public class Customer : AggregateRoot
    {
        public Customer(IEnumerable<IDomainEvent> events) : base(events)
        {
        }
        protected Customer()
        {
        }
        protected Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Address Address { get; private set; }
        public static Customer CreateCustomer(string firstName, string lastName)
        {
            var cust = new Customer();
            cust.Apply(new CustomerCreated(Guid.NewGuid().ToString(), firstName, lastName));
            return cust;
        }
        public void ChangeName(string firstName, string lastName)
        {
            Apply(new CustomerNameChanged(Id.ToString(), firstName, lastName));
        }
        public void ChangeAddress(string country, string city, string street)
        {
            Apply(new AddressChanged(Id.ToString(), country, city, street));
        }
        public void On(CustomerCreated customer)
        {
            Id = Guid.Parse(customer.CustomerId);
            FirstName = customer.FirstName;
            LastName = customer.LastName;
        }
        public void On(AddressChanged address)
        {
            Address = new Address
            {
                Country = address.Country,
                City = address.City,
                Street = address.Street
            };
        }
    }
}
