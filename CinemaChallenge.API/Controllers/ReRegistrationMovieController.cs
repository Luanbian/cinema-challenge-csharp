using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReRegistrationMovieController(IUpdateMovie update) : ControllerBase
    {
        private readonly IUpdateMovie update = update;

        [HttpPut]
        public IActionResult Handle([FromQuery] string id, [FromBody] MovieDto movieDto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                update.Perform(id, movieDto);
                return Ok($"item {id} recadastrado com sucesso");
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
