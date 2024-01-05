﻿using System.ComponentModel.DataAnnotations;

namespace CinemaChallenge.Application.DTOs
{
    public record LoginDto(string Email, string Password)
    {
        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; init; } = Email;

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string Password { get; init; } = Password;
    }
}
