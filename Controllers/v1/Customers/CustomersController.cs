using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Customers;

[ApiController]
[Route("api/customers")]
public class CustomersController : ControllerBase
{
    protected readonly ICustomerRepository services;

    public CustomersController(ICustomerRepository customerRepository)
    {
        services = customerRepository;
    }
}
