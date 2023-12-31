using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Domain.Entities;

namespace CinemaChallenge.Application.Interfaces
{
    public interface IFindMovie
    {
        List<Movie> Perform(MovieProps data);
    }
}
