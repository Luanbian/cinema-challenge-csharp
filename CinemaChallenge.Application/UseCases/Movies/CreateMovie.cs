using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases
{
    public class CreateMovie(ICreateRepository<Movie> create) : ICreate<Movie, MovieDto>
    {
        private readonly ICreateRepository<Movie> repository = create;
        public Movie Perform(MovieDto data)
        {
            string title = data.Title;
            string synopsis = data.Synopsis;
            string? releaseDate = data.ReleaseDate;
            Movie movie = Movie.Create(title, synopsis, releaseDate);
            repository.Create(movie);
            return movie;
        }
    }
}
