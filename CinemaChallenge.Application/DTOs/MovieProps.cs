namespace CinemaChallenge.Application.DTOs
{
    public record MovieProps
    {
        public string? Title { get; init; }

        public string? Synopsis { get; init; }

        public string? ReleaseDate { get; init; }
    }
}
