namespace CinemaChallenge.Infra.Data.Interfaces
{
    public interface IDeleteRepository
    {
        Task Delete(Guid id);
    }
}
