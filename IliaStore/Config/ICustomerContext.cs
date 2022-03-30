using MongoDB.Driver;
using IliaStore.Models;

namespace IliaStore.Config
{
    public interface ICustomerContext
    {
        IMongoCollection<Customer> Customers { get; }
    }
}