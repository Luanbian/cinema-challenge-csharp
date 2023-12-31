using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases
{
    public class FindMovie(IFindRepository<Movie> find) : IFindMovie
    {
        private readonly IFindRepository<Movie> repository = find;
        public List<Movie> Perform()
        {
            return repository.FindAll();
        }
    }
}
