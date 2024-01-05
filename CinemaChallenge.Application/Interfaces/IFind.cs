namespace CinemaChallenge.Application.Interfaces
{
    public interface IFind<T, I>
    {
        Task<List<T>> Perform(I data);
    }
}
