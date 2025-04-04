using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Data;
using Selu383.SP25.P03.Api.Features.Users;
using Selu383.SP25.P03.Api.Features.Movies;
using Selu383.SP25.P03.Api.Features.Theaters;
namespace Selu383.SP25.P03.Api.Controllers
{

    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly DbSet<Movie> movies;
        private readonly DataContext dataContext;
        private readonly DbSet<User> users;
        private readonly UserManager<User> userManager;

        public MovieController(DataContext dataContext, UserManager<User> userManager)
        {
            this.dataContext = dataContext;
            movies = dataContext.Set<Movie>();
            users = dataContext.Set<User>();
            this.userManager = userManager;
        }

        [HttpGet]
        public IQueryable<MovieDto> GetAllMovies()
        {
            return GetMovieDtos(movies);
        }

        private static IQueryable<MovieDto> GetMovieDtos(IQueryable<Movie> movies)
        {
            return movies
                .Select(x => new MovieDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    Genre = x.Genre,
                    Year = x.Year,
                    AgeRating = x.AgeRating,
                    Poster = x.Poster
                });
        }


        [HttpPost]

        public ActionResult<MovieDto> CreateMovies(MovieDto dto)
        {
            var movie = new Movie
            {
                Title = dto.Title,
                Id = dto.Id,
                Genre = dto.Genre,
                AgeRating = dto.AgeRating,
                Poster = dto.Poster
            };


            dataContext.SaveChanges();

            dto.Id = movie.Id;

            return Ok(movie);

        }


    }
}































