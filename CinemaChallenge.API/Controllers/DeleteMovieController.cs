using CinemaChallenge.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaChallenge.API.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class DeleteMovieController(IDeleteMovie delete) : ControllerBase
    {
        private readonly IDeleteMovie delete = delete;

        [HttpDelete]
        public IActionResult Handle([FromQuery] string id)
        {
            try
            {
                delete.Perform(id);
                return Ok($"item {id} excluido com sucesso");
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
