using MicroService.Shoping.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Shoping.Customer.Domain.Events
{
    public class CustomerCreated : IDomainEvent
    {
        public CustomerCreated(string customerId, string firstName, string lastName)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
        }

        public string CustomerId { get; }
        public string FirstName { get; }
        public string LastName { get; }
    }
}
