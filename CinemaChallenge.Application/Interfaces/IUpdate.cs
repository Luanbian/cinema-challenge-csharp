namespace CinemaChallenge.Application.Interfaces
{
    public interface IUpdate<T>
    {
        Task Perform(string id, T data);
    }
}
