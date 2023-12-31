using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Domain.Interfaces;

namespace CinemaChallenge.Application.Interfaces
{
    public interface IFindMovie
    {
        List<Movie> Perform(IMovie data);
    }
}
