using CinemaChallenge.Domain.Enums;

namespace CinemaChallenge.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Roles { get; set; }

        private User(string name, string email, string password)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Password = password;
            Roles = Roles.trainee;
        }

        public static User Create (string name, string email, string password)
        {
            return new User(name, email, password);
        }
    }
}
