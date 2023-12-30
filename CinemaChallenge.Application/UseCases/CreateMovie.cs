using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases
{
    public class CreateMovie(ICreateRepository<Movie> create) : ICreateMovie
    {
        private readonly ICreateRepository<Movie> repository = create;
        public Movie Perform()
        {
            string title = "Clube da luta";
            string synopsis = "Não falamos sobre o clube da luta";
            string releaseDate = "15/10/1999";
            Movie movie = Movie.Create(title, synopsis, releaseDate);
            repository.Create(movie);
            return movie;
        }
    }
}
