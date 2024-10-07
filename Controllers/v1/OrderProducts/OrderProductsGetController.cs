using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.OrderProducts;

[ApiController]
[Route("api/orderProducts")]
[Tags("orderProducts")]
public class OrderProductsGetController : OrderProductsController
{
    public OrderProductsGetController(IOrderProductRepository orderProductRepository) : base(orderProductRepository)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAllOrderProducts()
    {
        var orderProducts = await services.GetAll();
        if (orderProducts == null || !orderProducts.Any())
        {
            return NoContent();
        }
        return Ok(orderProducts);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrderProductById(int id)
    {
        var orderProduct = await services.GetById(id);
        if (orderProduct == null)
        {
            return NotFound();
        }
        return Ok(orderProduct);
    }
}
