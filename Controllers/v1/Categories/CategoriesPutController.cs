using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.V1.Categories;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Categories;

[ApiController]
[Route("api/v1/categories")]
[Tags("categories")]

public class CategoriesUpdateController : CategoriesController
{
    public CategoriesUpdateController(ICategoryRepository categoryRepository) : base(categoryRepository)
    {
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCategory(int id, Category category)
    {
        if (id != category.Id)
        {
            return BadRequest();
        }
        await services.Update(category);
        return Ok("Category updated");
    }
}
