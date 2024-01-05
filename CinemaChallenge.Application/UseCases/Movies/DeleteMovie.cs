using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases.Movies
{
    public class DeleteMovie(IDeleteRepository delete) : IDelete
    {
        private readonly IDeleteRepository repository = delete;
        public async Task Perform(string id)
        {
            await repository.Delete(new Guid(id));
        }
    }
}
