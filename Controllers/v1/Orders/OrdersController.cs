using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Orders;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    protected readonly IOrderRepository services;
    public OrdersController(IOrderRepository orderRepository)
    {
        services = orderRepository;
    }
}
