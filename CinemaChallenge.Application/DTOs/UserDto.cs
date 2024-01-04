using System.ComponentModel.DataAnnotations;

namespace CinemaChallenge.Application.DTOs
{
    public class UserDto(string Name, string Email, string Password)
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Name { get; init; } = Name;

        [Required(ErrorMessage = "email é obrigatório")]
        public string Email { get; init; } = Email;

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string Password { get; init; } = Password;
    }
}
