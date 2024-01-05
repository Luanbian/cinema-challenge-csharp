using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers.Users
{
    [Route("api/auth/login")]
    [ApiController]
    public class LoginController(ILogin login) : ControllerBase
    {
        private readonly ILogin login = login;
        [HttpPost]
        public async Task<IActionResult> Handle([FromBody] LoginDto loginDto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                string token = await login.Perform(loginDto.Email, loginDto.Password);
                return Ok(token);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
