using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.V1.Categories;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Categories;

[ApiController]
[Route("api/v1/categories")]
[Tags("categories")]

public class CategoriesPostController : CategoriesController
{
    public CategoriesPostController(ICategoryRepository categoryRepository) : base(categoryRepository)
    {
    }

    [HttpPost]
    [Authorize]

    public async Task<IActionResult> AddCategory(Category category)
    {
        await services.Add(category);
        return Ok("Category created");
    }
}
