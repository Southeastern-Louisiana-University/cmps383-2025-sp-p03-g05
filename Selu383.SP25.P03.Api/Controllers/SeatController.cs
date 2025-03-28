using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Data;
using Selu383.SP25.P03.Api.Features.Seats;

namespace Selu383.SP25.P03.Api.Controllers
{
    [Route("api/seats")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly DbSet<Seat> seats;
        private readonly DataContext dataContext;

        public SeatController(DataContext dataContext)
        {
            this.dataContext = dataContext;
            seats = dataContext.Set<Seat>();
        }

        [HttpGet("{theaterId}")]
        public IQueryable<SeatDto> GetSeats(int theaterId)
        {
            return seats.Where(s => s.TheaterId == theaterId)
                        .Select(s => new SeatDto
                        {
                            Id = s.Id,
                            TheaterId = s.TheaterId,
                            Row = s.Row,
                            Col = s.Col,
                            IsTaken = s.IsTaken
                        });
        }

        [HttpPost("reserve")]
        public IActionResult ReserveSeats([FromBody] List<int> seatIds)
        {
            var selectedSeats = seats.Where(s => seatIds.Contains(s.Id)).ToList();

            if (selectedSeats.Any(s => s.IsTaken))
            {
                return BadRequest(new { message = "Some seats are already taken!" });
            }

            selectedSeats.ForEach(s => s.IsTaken = true);
            dataContext.SaveChanges();

            return Ok(new { message = "Seats Reserved!" });
        }
    }
}
