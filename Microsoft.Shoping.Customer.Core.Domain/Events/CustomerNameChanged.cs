using MicroService.Shoping.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Shoping.Customer.Domain.Events
{
    public class CustomerNameChanged : IDomainEvent
    {
        public CustomerNameChanged(string customerId, string firstName, string lastName)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
        }

        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
