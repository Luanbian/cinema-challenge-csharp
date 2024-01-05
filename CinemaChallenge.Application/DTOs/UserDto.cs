using System.ComponentModel.DataAnnotations;

namespace CinemaChallenge.Application.DTOs
{
    public record UserDto
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Name { get; init; }

        [Required(ErrorMessage = "email é obrigatório")]
        public string Email { get; init; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string Password { get; init; }

        public UserDto(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
