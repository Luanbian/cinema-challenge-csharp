namespace CinemaChallenge.Application.Interfaces
{
    public interface ICreate<T, Dto>
    {
        Task<T> Perform(Dto data);
    }
}
