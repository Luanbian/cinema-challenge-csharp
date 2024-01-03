using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases
{
    public class DeleteMovie(IDeleteRepository delete) : IDeleteMovie
    {
        private readonly IDeleteRepository repository = delete;
        public void Perform(string id)
        {
            repository.Delete(new Guid(id));
        }
    }
}
