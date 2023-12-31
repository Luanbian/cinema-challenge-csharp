using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class CreateMovieController(ICreateMovie create) : ControllerBase
    {
        private readonly ICreateMovie create = create;
        [HttpPost]
        public IActionResult Handle([FromBody] MovieDto movieDto)
        {
            try
            {
                if(!ModelState.IsValid) return BadRequest(ModelState);           
                Movie movie = create.Perform(movieDto);
                return Ok(movie);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
