using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers.Users
{
    [Route("api/users")]
    [ApiController]
    public class CreateUserController(ICreate<User, UserDto> create) : ControllerBase
    {
        private readonly ICreate<User, UserDto> create = create;

        [HttpPost]
        public async Task<IActionResult> Handle([FromBody] UserDto userDto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                User user = await create.Perform(userDto);
                return Ok(user);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
