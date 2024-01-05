using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers.Users
{
    [Route("api/auth/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Handle([FromBody] LoginDto loginDto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                string token = await Login.Perform(loginDto);
                return Ok(token);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
