using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers.Movies
{
    [Route("api/movies")]
    [ApiController]
    public class UpdateMovieController(IUpdate<IMovie> update) : ControllerBase
    {
        private readonly IUpdate<IMovie> update = update;
        [HttpPatch]
        public async Task<IActionResult> Handle([FromQuery] string id, [FromBody] IMovie data)
        {
            try
            {
                await update.Perform(id, data);
                return Ok($"atualizado o item {id} com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
