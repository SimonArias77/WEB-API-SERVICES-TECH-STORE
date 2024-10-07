using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Config;
using CONSTRUCCION_AVANZADA_API_CON_.NET.DTOs.Requests;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Controllers.v1.Auth;

[ApiController]
[Route("api/v1/auth")]
public class AuthController : ControllerBase
{
    protected readonly IUserRepository services;

    public AuthController(IUserRepository userRepository)
    {
        services = userRepository;
    }


    // METODO QUE ME GENERA UN JWT
    [HttpPost]
    public async Task<IActionResult> GenerateToken(User user)
    {
        var token = JWT.GenerateJwtToken(user);

        return Ok($"acá está su token: {token}");
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login(LoginDto data)
    {
        var user = await services.GetByEmail(data.Email);

        if (user == null)
            return BadRequest("el usuario no existe");

        if (user.Password != data.Password)
            return BadRequest("contraseña incorrecta");

        var token = JWT.GenerateJwtToken(user);

        if (user.Role != "admin")
        {
            return Unauthorized($"no tienes los permisos necesarios");
        }
        return Ok($"acá está su token: {token}");
    }
}
