using CinemaChallenge.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers.Movies
{
    [Route("api/movies")]
    [ApiController]
    public class DeleteMovieController(IDelete delete) : ControllerBase
    {
        private readonly IDelete delete = delete;

        [HttpDelete]
        public IActionResult Handle([FromQuery] string id)
        {
            try
            {
                delete.Perform(id);
                return Ok($"item {id} excluido com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
