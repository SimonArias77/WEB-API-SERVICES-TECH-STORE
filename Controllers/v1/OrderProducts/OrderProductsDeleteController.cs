using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.OrderProducts;

[ApiController]
[Route("api/orderProducts")]
[Tags("orderProducts")]
public class OrderProductsDeleteController : OrderProductsController
{
    public OrderProductsDeleteController(IOrderProductRepository orderProductRepository) : base(orderProductRepository)
    {
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteOrderProduct(int id)
    {
        var orderProduct = await services.GetById(id);
        if (orderProduct == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("OrderProduct deleted");
    }
}
