using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers.Movies
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReRegistrationMovieController(IUpdate<MovieDto> update) : ControllerBase
    {
        private readonly IUpdate<MovieDto> update = update;

        [HttpPut]
        public async Task<IActionResult> Handle([FromQuery] string id, [FromBody] MovieDto movieDto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                await update.Perform(id, movieDto);
                return Ok($"item {id} recadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
