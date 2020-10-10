using MicroService.Shoping.Customer.ApplicationService.Customers.Dtoes;
using MicroService.Shoping.Customers.ApplicationService.Customers.Dtoes;
using MicroService.Shoping.Customers.Domain.Entities;
using MicroService.Shoping.Customers.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroService.Shoping.Customers.ApplicationService.Customers
{
    public class CustomerService
    {

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }
        private readonly ICustomerRepository _repository;
        public async Task<Guid> SaveCustomer(SaveCustomerDto customerDto)
        {
            var customer = Customer.CreateCustomer(customerDto.FirstName, customerDto.LastName);
            var id =await _repository.SaveAsync(customer);
            return id;
        }
        public async Task<Guid> UpdateCustomer(CustomerDto customerDto)
        {
            var customerData =await _repository.GetCustomer(Guid.Parse(customerDto.CustomerId));
            customerData.ChangeName(customerDto.FirstName, customerDto.LastName);
            var id =await _repository.SaveAsync(customerData);
            return id;
        }
        public Task<CustomerDto> GetCustomer(Guid guid)
        {

        }
    }
}
