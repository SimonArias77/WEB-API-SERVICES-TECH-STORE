using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.OrderProducts;

[ApiController]
[Route("api/orderProducts")]
[Tags("orderProducts")]
public class OrderProductsPutController : OrderProductsController
{
    public OrderProductsPutController(IOrderProductRepository orderProductRepository) : base(orderProductRepository)
    {
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateOrderProduct(int id, OrderProduct orderProduct)
    {
        if (id != orderProduct.Id)
        {
            return BadRequest();
        }
        await services.Update(orderProduct);
        return Ok("OrderProduct updated");
    }
}
