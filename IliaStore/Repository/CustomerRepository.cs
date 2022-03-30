using System.Collections.Generic;
using System.Threading.Tasks;
using IliaStore.Models;
using IliaStore.Config;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace IliaStore.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICustomerContext _customerContext;

        public CustomerRepository(ICustomerContext customerContext)
        {
            _customerContext = customerContext;
        }
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _customerContext.Customers.Find(_ => true).ToListAsync();
        }

        public Task<Customer> GetCustomer(long id)
        {
            FilterDefinition<Customer> filter = Builders<Customer>.Filter.Eq(m => m.Id, id);
            return _customerContext
                    .Customers
                    .Find(filter)
                    .FirstOrDefaultAsync();
        }

        public async Task Create(Customer customer)
        {
            await _customerContext.Customers.InsertOneAsync(customer);
        }
        public async Task<long> GetNextId()
        {
            return await _customerContext.Customers.CountDocumentsAsync(new BsonDocument()) + 1;
        }
    }
}