using CinemaChallenge.Domain.Entities;

namespace CinemaChallenge.Application.Interfaces
{
    public interface IFindMovie
    {
        List<Movie> Perform();
    }
}
