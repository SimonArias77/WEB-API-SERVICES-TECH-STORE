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
public class CustomersPutController : CustomersController
{
    public CustomersPutController(ICustomerRepository customerRepository) : base(customerRepository)
    {
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCustomer(int id, Customer customer)
    {
        if (id != customer.Id)
        {
            return BadRequest();
        }
        await services.Update(customer);
        return Ok("Customer updated");
    }
}
