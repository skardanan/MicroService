using MicroService.Shoping.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Shoping.Customers.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Country;
            yield return City;
            yield return Street;
        }
    }
}
