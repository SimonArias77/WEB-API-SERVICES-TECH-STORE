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
public class CategoriesDeleteController : CategoriesController
{
    public CategoriesDeleteController(ICategoryRepository categoryRepository) : base(categoryRepository)
    {
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        var category = await services.GetById(id);
        if (category == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("Category deleted");
    }
}
