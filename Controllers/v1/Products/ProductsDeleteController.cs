using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Products;

[ApiController]
[Route("api/products")]
[Tags("products")]
public class ProductsDeleteController : ProductsController
{
    public ProductsDeleteController(IProductRepository productRepository) : base(productRepository)
    {
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await services.GetById(id);
        if (product == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("Product deleted");
    }
}
