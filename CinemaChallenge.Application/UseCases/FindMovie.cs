using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases
{
    public class FindMovie(IFindRepository<Movie> find) : IFindMovie
    {
        private readonly IFindRepository<Movie> repository = find;
        public List<Movie> Perform(MovieProps data)
        {
            if (data == null) return repository.FindAll();
            return repository.FindBy(movie => 
                (data.Title == null || movie.Title == data.Title) &&
                (data.Synopsis == null || movie.Synopsis == data.Synopsis) &&
                (data.ReleaseDate == null || movie.ReleaseDate == data.ReleaseDate)
            );
        }
    }
}
