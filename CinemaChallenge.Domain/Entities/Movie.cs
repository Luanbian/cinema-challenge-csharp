using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChallenge.Domain.Entities
{
    internal class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string? ReleaseDate { get; set; }

        private Movie(string title, string synopsis, string? releaseDate)
        {
            Id = Guid.NewGuid();
            Title = title;
            Synopsis = synopsis;
            ReleaseDate = releaseDate ?? "Em breve";
        }

        public static Movie Create (string title, string synopsis, string? releaseDate)
        {
            return new Movie(title, synopsis, releaseDate);
        }
    }
}
