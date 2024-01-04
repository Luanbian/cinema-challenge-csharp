using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Interfaces;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases
{
    public class UpdateMovie(IUpdateRepository<IMovie> update) : IUpdate<IMovie>, IUpdate<MovieDto>
    {
        private readonly IUpdateRepository<IMovie> repository = update;
        public void Perform(string id, IMovie data)
        {
            repository.Update(new Guid(id), data);
        }

        public void Perform(string id, MovieDto data)
        {
            IMovie movie = new()
            {
                Title = data.Title,
                Synopsis = data.Synopsis,
                ReleaseDate = data.ReleaseDate,
            };
            repository.Update(new Guid(id), movie);
        }
    }
}
