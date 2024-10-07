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
public class OrdersDeleteController : OrdersController
{
    public OrdersDeleteController(IOrderRepository orderRepository) : base(orderRepository)
    {
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOrder(int id)
    {
        var order = await services.GetById(id);
        if (order == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("Order deleted");
    }
}

