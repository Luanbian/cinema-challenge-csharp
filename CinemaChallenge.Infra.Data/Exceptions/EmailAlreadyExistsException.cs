namespace CinemaChallenge.Infra.Data.Exceptions
{
    public class EmailAlreadyExistsException(string message) : Exception(message)
    {
    }
}
