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
public class UsersDeleteController : UsersController
{
    public UsersDeleteController(IUserRepository userRepository) : base(userRepository)
    {
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var user = await services.GetById(id);
        if (user == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("User deleted");
    }
}
