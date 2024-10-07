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
public class OrdersPutController : OrdersController
{
  public OrdersPutController(IOrderRepository orderRepository) : base(orderRepository)
  {
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> UpdateOrder(int id, Order order)
  {
    if (id != order.Id)
    {
      return BadRequest();
    }
    await services.Update(order);
    return Ok("Order updated");
  }
}
