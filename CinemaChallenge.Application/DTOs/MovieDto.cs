using System.ComponentModel.DataAnnotations;

namespace CinemaChallenge.Application.DTOs
{
    public record MovieDto(string Title, string Synopsis, string? ReleaseDate)
    {
        [Required(ErrorMessage = "Título é obrigatório")]
        public string Title { get; init; } = Title;

        [Required(ErrorMessage = "Sinopse é obrigatória")]
        public string Synopsis { get; init; } = Synopsis;
        public string? ReleaseDate { get; init; } = ReleaseDate;
    }
}
