using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Data;
using Selu383.SP25.P03.Api.Features.Seats;
using Selu383.SP25.P03.Api.Features.Tickets;

namespace Selu383.SP25.P03.Api.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly DbSet<Ticket> tickets;
        private readonly DbSet<Seats> seats;
        private readonly DataContext dataContext;

        public TicketController(DataContext dataContext)
        {
            this.dataContext = dataContext;
            tickets = dataContext.Set<Ticket>();
            seats = dataContext.Set<Seats>();
        }

        [HttpPost("purchase")]
        public IActionResult PurchaseTicket([FromBody] TicketDto request)
        {
            var selectedSeats = seats.Where(s => request.SeatIds.Contains(s.Id)).ToList();

            if (selectedSeats.Any(s => s.IsTaken))
            {
                return BadRequest(new { message = "Some seats are already taken!" });
            }

            // Marks seats as taken
            selectedSeats.ForEach(s => s.IsTaken = true);

            // Create new ticket
            var ticket = new Ticket
            {
                SeatIds = request.SeatIds,
                AmountPaid = request.AmountPaid,
                Email = request.Email,
            };

            tickets.Add(ticket);
            dataContext.SaveChanges();

            return Ok(new { message = "Ticket Purchased!", ticketNumber = ticket.TicketNumber });
        }

        [HttpGet("{ticketId}")]
        public IActionResult GetTicket(int ticketId)
        {
            var ticket = tickets.FirstOrDefault(t => t.Id == ticketId);
            if (ticket == null)
            {
                return NotFound(new { message = "Ticket not found" });
            }

            var ticketDto = new TicketDto
            {
                Id = ticket.Id,
                TicketNumber = ticket.TicketNumber,
                SeatIds = ticket.SeatIds,
                AmountPaid = ticket.AmountPaid,
                Email = ticket.Email,
                PurchaseDate = ticket.PurchaseDate
            };

            return Ok(ticketDto);
        }
    }
}
