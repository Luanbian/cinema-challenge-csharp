using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Domain.Entities;

namespace CinemaChallenge.Application.Interfaces
{
    public interface ICreateMovie
    {
        Movie Perform(MovieDto data);
    }
}
