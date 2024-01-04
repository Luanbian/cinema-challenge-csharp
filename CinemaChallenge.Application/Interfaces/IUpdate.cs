namespace CinemaChallenge.Application.Interfaces
{
    public interface IUpdate<T>
    {
        void Perform(string id, T data);
    }
}
