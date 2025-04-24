using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Data;
using Selu383.SP25.P03.Api.Features.Seats;
using Selu383.SP25.P03.Api.Features.Tickets;
using Microsoft.AspNetCore.Identity;
using Selu383.SP25.P03.Api.Features.Users;

namespace Selu383.SP25.P03.Api.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly DbSet<Ticket> tickets;
        private readonly DbSet<Seat> seats;
        private readonly UserManager<User> userManager;
        private readonly DataContext dataContext;

        public TicketController(DataContext dataContext, UserManager<User> userManager)
        {
            this.dataContext = dataContext;
            this.userManager = userManager;
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

            selectedSeats.ForEach(s => s.IsTaken = true);

            var user = userManager.FindByEmailAsync(request.Email).Result;
            if (user == null)
            {
                return BadRequest(new { message = "User not found" });
            }

            var ticket = new Ticket
            {
                SeatIds = request.SeatIds,
                AmountPaid = request.AmountPaid,
                Email = request.Email,
                UserId = user.Id,  
            };

            tickets.Add(ticket);
            dataContext.SaveChanges();

            var ticketDto = new TicketDto
            {
                Id = ticket.Id,
                TicketNumber = ticket.TicketNumber,
                SeatIds = ticket.SeatIds,
                AmountPaid = ticket.AmountPaid,
                Email = ticket.Email,
                PurchaseDate = ticket.PurchaseDate,
                UserId = ticket.UserId,
                UserName = user.UserName
            };

            return Ok(new { message = "Ticket Purchased!", ticket = ticketDto });
        }

        [HttpGet("user/{userId}")]
        public IActionResult GetUserTickets(int userId)
        {
            var userTickets = tickets.Where(t => t.UserId == userId).ToList();

            if (userTickets == null || !userTickets.Any())
            {
                return NotFound(new { message = "No tickets found for this user" });
            }

            var ticketDtos = userTickets.Select(t => new TicketDto
            {
                Id = t.Id,
                TicketNumber = t.TicketNumber,
                SeatIds = t.SeatIds,
                AmountPaid = t.AmountPaid,
                Email = t.Email,
                PurchaseDate = t.PurchaseDate,
                UserId = t.UserId,
                UserName = t.User.UserName
            }).ToList();

            return Ok(ticketDtos);
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
