namespace CinemaChallenge.Application.Interfaces
{
    public interface ILogin
    {
        Task<string> Perform(string email, string password);
    }
}
