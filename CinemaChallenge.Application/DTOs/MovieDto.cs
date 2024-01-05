using System.ComponentModel.DataAnnotations;

namespace CinemaChallenge.Application.DTOs
{
    public record MovieDto
    {
        [Required(ErrorMessage = "Título é obrigatório")]
        public string Title { get; init; }

        [Required(ErrorMessage = "Sinopse é obrigatória")]
        public string Synopsis { get; init; }
        public string? ReleaseDate { get; init; }

        public MovieDto(string title, string synopsis, string? releaseDate)
        {
            Title = title;
            Synopsis = synopsis;
            ReleaseDate = releaseDate;
        }
    }
}
