namespace CinemaChallenge.Application.Interfaces
{
    public interface ICreate<T, Dto>
    {
        T Perform(Dto data);
    }
}
