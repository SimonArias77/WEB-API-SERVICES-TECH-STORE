using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.V1.Categories;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Categories;

[ApiController]
[Route("api/v1/categories")]
[Tags("categories")]

public class CategoriesGetController : CategoriesController
{
    public CategoriesGetController(ICategoryRepository categoryRepository) : base(categoryRepository)
    {
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        var categories = await services.GetAll();
        if (categories == null || !categories.Any())
        {
            return NoContent();
        }
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        var category = await services.GetById(id);
        if (category == null)
        {
            return NotFound();
        }
        return Ok(category);
    }
}
