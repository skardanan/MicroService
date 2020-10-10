using MicroService.Shoping.Customers.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace MicroService.Shoping.Customers.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomer(Guid guid);
        Task<Guid> SaveAsync(Customer customer);
    }
}
