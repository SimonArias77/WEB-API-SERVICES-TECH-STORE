using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.OrderProducts;

[ApiController]
[Route("api/orderProducts")]
public class OrderProductsController : ControllerBase
{
    protected readonly IOrderProductRepository services;
    public OrderProductsController(IOrderProductRepository orderProductRepository)
    {
        services = orderProductRepository;
    }
}
