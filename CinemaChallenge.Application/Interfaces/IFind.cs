namespace CinemaChallenge.Application.Interfaces
{
    public interface IFind<T, I>
    {
        List<T> Perform(I data);
    }
}
