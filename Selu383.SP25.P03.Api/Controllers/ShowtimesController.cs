using Selu383.SP25.P03.Api.Features.Showtimes;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Selu383.SP25.P03.Api.Data;
using Selu383.SP25.P03.Api.Features.Theaters;

namespace Selu383.SP25.P03.Api.Controllers
{
    [Route("api/showtimes")]
    [ApiController]
    public class ShowtimesController: ControllerBase
    {
        private readonly DataContext dataContext;
        private readonly DbSet<Showtime> showtimes;

        public ShowtimesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
            showtimes = dataContext.Set<Showtime>();

        }
        [HttpGet]
        public IActionResult GetAllShowtimes()
        {
            var data = dataContext
                .Set<Showtime>()
                .Select(Showtime => new ShowtimesGetDto
                {
                    Id = Showtime.Id,
                    StartTime = Showtime.StartTime,
                    MovieId = Showtime.MovieId,
                    TheaterId = Showtime.TheaterId,
                    Format = Showtime.Format,
                    Available = Showtime.Available
                }).ToList();

            return Ok(data);
        }

        [HttpGet("{movieId}")]
        public IActionResult GetShowtimesMovie(int movieId)
        {
            var data = dataContext
                .Set<Showtime>()
                .Where(x => (x.MovieId == movieId))
                .Select(Showtime => new ShowtimesGetDto
                {
                    Id = Showtime.Id,
                    StartTime = Showtime.StartTime,
                    MovieId = Showtime.MovieId,
                    TheaterId = Showtime.TheaterId,
                    Format = Showtime.Format,
                    Available = Showtime.Available
                }).ToList();

            return Ok(data);
        }

        [HttpPut("{theaterId}/{movieId}")]
        public IActionResult UpdateShowtime([FromBody] ShowtimeUpdateDto updateDto, int theaterId, int movieId)
        {
            var showtimeToUpdate = dataContext.Set<Showtime>()
                .FirstOrDefault(Showtime => (Showtime.TheaterId == theaterId) && (Showtime.MovieId == movieId));

            if (showtimeToUpdate == null)
            {
                return BadRequest("Showtime not found");
                //could also be theater or movie not found
            }
            //screen has to have theater foreign key
            //accept a screen and a schedule 
            //schedule describes when and what will be shown on the specific screen

            showtimeToUpdate.StartTime = updateDto.StartTime;
            showtimeToUpdate.Format = updateDto.Format;
            showtimeToUpdate.Available = updateDto.Available;

            dataContext.SaveChanges();

            var showtimeReturn = new ShowtimesGetDto
            {
                StartTime = showtimeToUpdate.StartTime,
                Format = showtimeToUpdate.Format,
                Available = showtimeToUpdate.Available

            };
            return Ok(showtimeReturn);

        }


        //Create a new showtime

        //Delete a showtime
       
    }
}
