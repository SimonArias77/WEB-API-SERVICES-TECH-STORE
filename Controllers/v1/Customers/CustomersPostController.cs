using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Customers;

[ApiController]
[Route("api/v1/customers")]
[Tags("customers")]
public class CustomersPostController : CustomersController
{
    public CustomersPostController(ICustomerRepository customerRepository) : base(customerRepository)
    {
    }

    [HttpPost]

    public async Task<IActionResult> AddCustomer(Customer customer)
    {
        await services.Add(customer);
        return Ok("Customer created");
    }
}
