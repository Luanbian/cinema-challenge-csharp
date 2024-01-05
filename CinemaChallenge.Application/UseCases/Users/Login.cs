using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.Exceptions;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases.Users
{
    public class Login(IFindRepository<User> find) : ILogin
    {
        private readonly IFindRepository<User> repository = find;
        public async Task<string> Perform(string email, string password)
        {
            try
            {
                List<User> users = await repository.FindBy(user => 
                    (email == user.Email)
                );
                return users.Count > 0 ? "sucesso" : "erro";
            } catch (UserNotExists ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
