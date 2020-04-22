using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab152_CreatingAPI.Models;

namespace Lab152_CreatingAPI.Services
{
    public interface IDAL
    {
        int CreateMovie(Movie m);
        int DeleteMovieById(int id);
        Movie GetMovieById(int id);
        IEnumerable<Movie> GetMoviesAll();
        IEnumerable<Movie> GetMoviesByGenres(string genres);
        //int UpdateMovietById(Movie mov);
    }
}
