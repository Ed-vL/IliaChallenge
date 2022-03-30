using System.Collections.Generic;
using System.Threading.Tasks;
using IliaStore.Models;

namespace IliaStore.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomer(long id);
        Task Create(Customer customer);
        Task<long> GetNextId();
    }
}