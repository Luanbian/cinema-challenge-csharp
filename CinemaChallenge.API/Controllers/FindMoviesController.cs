using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class FindMoviesController(IFindMovie find) : ControllerBase
    {
        private readonly IFindMovie find = find;

        [HttpGet]
        public IActionResult Handle()
        {
            try
            {
                List<Movie> movies = find.Perform();
                return Ok(movies);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
