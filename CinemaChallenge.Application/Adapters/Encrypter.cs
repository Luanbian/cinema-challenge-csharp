using CinemaChallenge.Application.Interfaces;
using static BCrypt.Net.BCrypt;

namespace CinemaChallenge.Application.Adapters
{
    public class Encrypter : IEncrypter
    {
        private const int salt = 12;

        public string Encrypt(string password)
        {
            string hashedPassword = HashPassword(password, salt);
            return hashedPassword;
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            bool checkPassword = Verify(password, hashedPassword);
            return checkPassword;
        }
    }
}
