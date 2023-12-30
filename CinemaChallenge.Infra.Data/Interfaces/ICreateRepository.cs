namespace CinemaChallenge.Infra.Data.Interfaces
{
    public interface ICreateRepository<T>
    {
        void Create(T data);
    }
}
