using System.ComponentModel.DataAnnotations;

namespace CinemaChallenge.Application.DTOs
{
    public record LoginDto
    {
        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; init; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string Password { get; init; }

        public LoginDto(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
