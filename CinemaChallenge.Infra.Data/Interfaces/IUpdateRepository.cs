namespace CinemaChallenge.Infra.Data.Interfaces
{
    public interface IUpdateRepository<T>
    {
        Task Update(Guid id, T data);
    }
}
