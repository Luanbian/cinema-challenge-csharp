namespace CinemaChallenge.Application.Interfaces
{
    public interface IAuthenticate
    {
        string GenerateToken(string data);
    }
}
