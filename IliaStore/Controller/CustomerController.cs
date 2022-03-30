using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IliaStore.Services;
using IliaStore.Models;

namespace IliaStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerService _customerServices;

        public CustomerController(ILogger<CustomerController> logger, ICustomerService customerServices)
        {
            _logger = logger;
            _customerServices = customerServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> Get()
        {
            return new ObjectResult(await _customerServices.GetAllCustomers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> Get(long id)
        {
            var customer = await _customerServices.GetCustomer(id);
            if (customer == null){
                return new NotFoundResult();
            } else {
                return new ObjectResult(customer);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> Post([FromBody] Customer customer)
        {
           return new ObjectResult(await _customerServices.AddCustomer(customer));
            
        }

    }
}
