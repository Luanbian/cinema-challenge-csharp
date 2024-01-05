namespace CinemaChallenge.Application.Interfaces
{
    public interface IEncrypter
    {
        string Encrypt(string password);
        bool VerifyPassword(string password, string hashedPassword);
    }
}
