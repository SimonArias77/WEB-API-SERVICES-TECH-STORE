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
public class OrderProductsPostController : OrderProductsController
{
    public OrderProductsPostController(IOrderProductRepository orderProductRepository) : base(orderProductRepository)
    {
    }

    [HttpPost]

    public async Task<IActionResult> AddOrderProduct(OrderProduct orderProduct)
    {
        await services.Add(orderProduct);
        return Ok("OrderProduct created");
    }
}
