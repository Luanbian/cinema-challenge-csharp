﻿using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.Exceptions;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases.Users
{
    public class CreateUser(ICreateRepository<User> create, IEncrypter encrypter) : ICreate<User, UserDto>
    {
        private readonly ICreateRepository<User> repository = create;
        private readonly IEncrypter encrypter = encrypter;
        public async Task<User> Perform(UserDto data)
        {
            try
            { 
                string Name = data.Name;
                string Email = data.Email;
                string Password = encrypter.Encrypt(data.Password);
                User user = User.Create(Name, Email, Password);
                await repository.Create(user);
                return user;
            } catch (EmailAlreadyExistsException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
