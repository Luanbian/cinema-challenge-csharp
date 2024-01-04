namespace CinemaChallenge.Domain.Interfaces
{
    public record IUser
    {
        public string? Name { get; init; }
        public string? Email { get; init; }
        public string? Password { get; init; }
    }
}
