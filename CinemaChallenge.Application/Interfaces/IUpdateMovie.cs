using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Domain.Interfaces;

namespace CinemaChallenge.Application.Interfaces
{
    public interface IUpdateMovie
    {
        void Perform(string id, IMovie data);
        void Perform(string id, MovieDto data);
    }
}
