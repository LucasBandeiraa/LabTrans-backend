using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Kognit.DTOs;
using Kognit.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kognit.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDTO userDto)
        {
            if (userDto == null) return BadRequest("Dados inválidos.");

            var res = await _userService.Create(userDto);
            if (res <= 0)
            {
                return StatusCode(500, "Erro ao criar o usuário.");
            }

            return Ok(res);
        }
    }

}
