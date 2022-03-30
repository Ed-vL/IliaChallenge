using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IliaStore.Models;
using IliaStore.Repository;


namespace IliaStore.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            var CustomerList = await _repository.GetAllCustomers();

            return CustomerList;

        }
        public async Task<Customer> GetCustomer(long Id)
        {
            var customer = await _repository.GetCustomer(Id);
            return customer;
        }
        public async Task<Customer> AddCustomer(Customer customer)
        {
            customer.Id = await _repository.GetNextId();
            try
            {
                _repository.Create(customer);
                return customer;
            } catch(Exception ex)
            {
                return customer;
            }
        } 
    }
}
