using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Orders;

[ApiController]
[Route("api/orders")]
[Tags("orders")]
public class OrdersGetController : OrdersController
{
    public OrdersGetController(IOrderRepository orderRepository) : base(orderRepository)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAllOrders()
    {
        var orders = await services.GetAll();
        if (orders == null || !orders.Any())
        {
            return NoContent();
        }
        return Ok(orders);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrderById(int id)
    {
        var order = await services.GetById(id);
        if (order == null)
        {
            return NotFound();
        }
        return Ok(order);
    }
}

