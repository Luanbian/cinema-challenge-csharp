using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Interfaces;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases
{
    public class UpdateMovie(IUpdateRepository<IMovie> update) : IUpdateMovie
    {
        private readonly IUpdateRepository<IMovie> repository = update;
        public void Perform(string id, IMovie data)
        {
            repository.Update(new Guid(id), data);
        }
    }
}
