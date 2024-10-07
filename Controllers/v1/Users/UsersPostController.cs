using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Users;

[ApiController]
[Route("api/users")]
[Tags("users")]
public class UsersPostController : UsersController
{
    public UsersPostController(IUserRepository userRepository) : base(userRepository)
    {
    }

    [HttpPost]
    [Authorize]

    public async Task<IActionResult> AddProduct(User user)
    {
        await services.Add(user);
        return Ok("User created");
    }
}
