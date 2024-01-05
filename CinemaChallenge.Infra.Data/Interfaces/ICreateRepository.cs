namespace CinemaChallenge.Infra.Data.Interfaces
{
    public interface ICreateRepository<T>
    {
        Task Create(T data);
    }
}
