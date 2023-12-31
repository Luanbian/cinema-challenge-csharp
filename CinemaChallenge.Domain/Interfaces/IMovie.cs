namespace CinemaChallenge.Domain.Interfaces
{
    public record IMovie
    {
        public string? Title { get; init; }

        public string? Synopsis { get; init; }

        public string? ReleaseDate { get; init; }
    }
}
