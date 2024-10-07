using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Products;

[ApiController]
[Route("api/products")]
[Tags("products")]
public class ProductsPostController : ProductsController
{
    public ProductsPostController(IProductRepository productRepository) : base(productRepository)
    {
    }

    [HttpPost]

    public async Task<IActionResult> AddProduct(Product product)
    {
        await services.Add(product);
        return Ok("Product created");
    }
}
