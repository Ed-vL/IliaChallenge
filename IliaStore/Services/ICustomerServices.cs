using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IliaStore.Models;

namespace IliaStore.Services
{
    public interface ICustomerService
    {
        public Task<IEnumerable<Customer>> GetAllCustomers();
        public Task<Customer> GetCustomer(long Id);
        public Task<Customer> AddCustomer(Customer customer);
    }
}