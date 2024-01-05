using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.Exceptions;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases.Users
{
    public class Login(IFindRepository<User> find, IEncrypter encrypter) : ILogin
    {
        private readonly IFindRepository<User> repository = find;
        private readonly IEncrypter encrypter = encrypter;
        public async Task<string> Perform(string email, string password)
        {
            try
            {
                List<User> users = await repository.FindBy(user => 
                    (email == user.Email)
                );
                bool checkPassword = encrypter.VerifyPassword(password, users[0].Password);
                if (checkPassword)
                {
                    return "token";
                } else
                {
                    throw new Exception("Senha incorreta");
                }
            } catch (UserNotExists ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
