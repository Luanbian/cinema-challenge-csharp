using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class FindMoviesController(IFindMovie find) : ControllerBase
    {
        private readonly IFindMovie find = find;

        [HttpGet]
        public IActionResult Handle([FromQuery] IMovie movieProps)
        {
            try
            {
                List<Movie> movies = find.Perform(movieProps);
                return Ok(movies);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
