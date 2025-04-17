using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Data;
using Selu383.SP25.P03.Api.Features.ComingSoonMovies;

namespace Selu383.SP25.P03.Api.Controllers
{
    [Route("api/comingsoon")]
    [ApiController]
    public class ComingSoonMovieController : ControllerBase
    {
        private readonly DbSet<ComingSoonMovies> comingSoonMovies;
        private readonly DataContext dataContext;

        public ComingSoonMovieController(DataContext dataContext)
        {
            this.dataContext = dataContext;
            comingSoonMovies = dataContext.Set<ComingSoonMovies>();
        }

        [HttpGet]
        public IQueryable<ComingSoonMovieDto> GetAllComingSoon()
        {
            return comingSoonMovies.Select(x => new ComingSoonMovieDto
            {
                Id = x.Id,
                Title = x.Title,
                Genre = x.Genre,
                ReleaseYear = x.ReleaseYear,
                AgeRating = x.AgeRating,
                Poster = x.Poster,
                Description = x.Description
            });
        }

        [HttpPost]
        public ActionResult<ComingSoonMovieDto> CreateComingSoonMovie(ComingSoonMovieDto dto)
        {
            var movie = new ComingSoonMovies
            {
                Title = dto.Title,
                Genre = dto.Genre,
                ReleaseYear = dto.ReleaseYear,
                AgeRating = dto.AgeRating,
                Poster = dto.Poster,
                Description = dto.Description
            };

            comingSoonMovies.Add(movie);
            dataContext.SaveChanges();

            dto.Id = movie.Id;

            return Ok(dto);
        }

        [HttpGet("{id}")]
        public ActionResult<ComingSoonMovieDto> GetById(int id)
        {
            var movie = comingSoonMovies
                .Where(x => x.Id == id)
                .Select(x => new ComingSoonMovieDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    Genre = x.Genre,
                    ReleaseYear = x.ReleaseYear,
                    AgeRating = x.AgeRating,
                    Poster = x.Poster,
                    Description = x.Description
                })
                .FirstOrDefault();

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }
    }
}
