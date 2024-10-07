using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Orders;

[ApiController]
[Route("api/orders")]
[Tags("orders")]
public class OrdersPostController : OrdersController
{
    public OrdersPostController(IOrderRepository orderRepository) : base(orderRepository)
    {
    }

    [HttpPost]

    public async Task<IActionResult> AddOrder(Order order)
    {
        await services.Add(order);
        return Ok("Order created");
    }
}
