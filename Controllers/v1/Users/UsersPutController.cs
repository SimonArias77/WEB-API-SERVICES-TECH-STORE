using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Users;

[ApiController]
[Route("api/users")]
[Tags("users")]
public class UsersPutController : UsersController
{
    public UsersPutController(IUserRepository userRepository) : base(userRepository)
    {
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, User user)
    {
        if (id != user.Id)
        {
            return BadRequest();
        }
        await services.Update(user);
        return Ok("User updated");
    }
}
