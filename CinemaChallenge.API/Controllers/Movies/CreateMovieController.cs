using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers.Movies
{
    [Route("api/movies")]
    [ApiController]
    public class CreateMovieController(ICreate<Movie, MovieDto> create) : ControllerBase
    {
        private readonly ICreate<Movie, MovieDto> create = create;
        [HttpPost]
        public async Task<IActionResult> Handle([FromBody] MovieDto movieDto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                Movie movie = await create.Perform(movieDto);
                return Ok(movie);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
