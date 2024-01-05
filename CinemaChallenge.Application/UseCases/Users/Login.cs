using CinemaChallenge.Application.Interfaces;

namespace CinemaChallenge.Application.UseCases.Users
{
    public class Login : ILogin
    {
        public async Task<string> Perform(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
