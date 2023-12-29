using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChallenge.Application.UseCases
{
    public class CreateMovie : ICreateMovie
    {
        public Movie Perform()
        {
            string title = "Clube da luta";
            string synopsis = "Não falamos sobre o clube da luta";
            string releaseDate = "15/10/1999";
            return Movie.Create(title, synopsis, releaseDate);
        }
    }
}
