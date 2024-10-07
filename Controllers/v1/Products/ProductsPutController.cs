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
public class ProductsPutController : ProductsController
{
    public ProductsPutController(IProductRepository productRepository) : base(productRepository)
    {
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, Product product)
    {
        if (id != product.Id)
        {
            return BadRequest();
        }
        await services.Update(product);
        return Ok("Product updated");
    }
}
