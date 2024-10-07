using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Customers;

[ApiController]
[Route("api/v1/customers")]
[Tags("customers")]
public class CustomersDeleteController : CustomersController
{
    public CustomersDeleteController(ICustomerRepository customerRepository) : base(customerRepository)
    {
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteCustomer(int id)
    {
        var customer = await services.GetById(id);
        if (customer == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("Customer deleted");
    }
}
