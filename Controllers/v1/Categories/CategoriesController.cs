
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.V1.Categories;

[ApiController]
[Route("api/v1/categories")]
public class CategoriesController : ControllerBase
{
    protected readonly ICategoryRepository services;

    public CategoriesController(ICategoryRepository categoryRepository)
    {
        services = categoryRepository;
    }
}
