using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Domain.Interfaces;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases.Movies
{
    public class FindMovie(IFindRepository<Movie> find) : IFind<Movie, IMovie>
    {
        private readonly IFindRepository<Movie> repository = find;
        public async Task<List<Movie>> Perform(IMovie data)
        {
            return data == null
                ? await repository.FindAll()
                : await repository.FindBy(movie =>
                (data.Title == null || movie.Title == data.Title) &&
                (data.Synopsis == null || movie.Synopsis == data.Synopsis) &&
                (data.ReleaseDate == null || movie.ReleaseDate == data.ReleaseDate)
            );
        }
    }
}
