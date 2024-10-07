using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Users;

[ApiController]
[Route("api/users")]
[Tags("users")]
public class UsersGetController : UsersController
{
    public UsersGetController(IUserRepository userRepository) : base(userRepository)
    {

    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await services.GetAll();
        if (users == null || !users.Any())
        {
            return NoContent();
        }
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var user = await services.GetById(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }
}
