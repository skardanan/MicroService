using MicroService.Shoping.Customers.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Shoping.Customer.ApplicationService.Customers
{
    public class CustomerService
    {

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }
        private readonly ICustomerRepository _repository;

    } 
}
