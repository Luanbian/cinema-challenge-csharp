using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class UpdateMovieController(IUpdateMovie update) : ControllerBase
    {
        private readonly IUpdateMovie update = update;
        [HttpPatch]
        public IActionResult Handle([FromQuery] string id, [FromBody] IMovie data)
        {
            try
            {
                update.Perform(id, data);
                return Ok($"atualizado o item {id} com sucesso");
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
