using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Users;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    protected readonly IUserRepository services;

    public UsersController(IUserRepository userRepository)
    {
        services = userRepository;
    }
}
