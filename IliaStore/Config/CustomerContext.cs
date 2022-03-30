using IliaStore.Models;
using MongoDB.Driver;
using System;

namespace IliaStore.Config
{
    public class CustomerContext: ICustomerContext
    {
        private readonly IMongoDatabase _db;
        public CustomerContext(DbConfig config)
        {
            var client = new MongoClient(config.ConnectionString);
            _db = client.GetDatabase(config.Database);
        }
        public IMongoCollection<Customer> Customers => _db.GetCollection<Customer>("Customers");
    }
}