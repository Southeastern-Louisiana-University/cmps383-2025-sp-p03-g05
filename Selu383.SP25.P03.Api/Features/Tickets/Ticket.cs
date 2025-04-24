using Selu383.SP25.P03.Api.Features.Seats;
using Selu383.SP25.P03.Api.Features.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Selu383.SP25.P03.Api.Features.Tickets
{
    public class Ticket
    {
        public int Id { get; set; }

        [ForeignKey("Showtime")]
        public int showtimeId { get; set; }
        public string TicketNumber { get; set; } = Guid.NewGuid().ToString();
        public List<int> SeatIds { get; set; } = new List<int>();
        public double AmountPaid { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;
        public int UserId { get; set; }  
        public User User { get; set; }  
    }

}
