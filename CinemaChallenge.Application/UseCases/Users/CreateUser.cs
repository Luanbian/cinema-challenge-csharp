using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases.Users
{
    public class CreateUser(ICreateRepository<User> create) : ICreate<User, UserDto>
    {
        private readonly ICreateRepository<User> repository = create;
        public User Perform(UserDto data)
        {
            string Name = data.Name;
            string Email = data.Email;
            string Password = data.Password;
            User user = User.Create(Name, Email, Password);
            repository.Create(user);
            return user;
        }
    }
}
