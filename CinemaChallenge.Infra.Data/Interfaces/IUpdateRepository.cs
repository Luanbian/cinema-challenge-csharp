namespace CinemaChallenge.Infra.Data.Interfaces
{
    public interface IUpdateRepository<T>
    {
        void Update(Guid id, T data);
    }
}
