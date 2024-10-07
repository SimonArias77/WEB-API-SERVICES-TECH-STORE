using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Products;

[ApiController]
[Route("api/products")]
[Tags("products")]
public class ProductsGetController : ProductsController
{
    public ProductsGetController(IProductRepository productRepository) : base(productRepository)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await services.GetAll();
        if (products == null || !products.Any())
        {
            return NoContent();
        }
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
        var product = await services.GetById(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }
}
