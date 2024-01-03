using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Domain.Interfaces;

namespace CinemaChallenge.Application.Interfaces
{
    public interface IUpdateMovie
    {
        void Perform(string id, IMovie data);
    }
}
