using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Customers;

[ApiController]
[Route("api/v1/customers")]
[Tags("customers")]
public class CustomersGetController : CustomersController
{
    public CustomersGetController(ICustomerRepository customerRepository) : base(customerRepository)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCustomers()
    {
        var customers = await services.GetAll();
        if (customers == null || !customers.Any())
        {
            return NoContent();
        }
        return Ok(customers);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCustomeryById(int id)
    {
        var customer = await services.GetById(id);
        if (customer == null)
        {
            return NotFound();
        }
        return Ok(customer);
    }

}
