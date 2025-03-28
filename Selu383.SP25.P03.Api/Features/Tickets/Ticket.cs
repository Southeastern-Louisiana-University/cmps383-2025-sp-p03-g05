using Selu383.SP25.P03.Api.Features.Seats;
using System.ComponentModel.DataAnnotations;

namespace Selu383.SP25.P03.Api.Features.Tickets
{
    public class Ticket
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; } = Guid.NewGuid().ToString();
        public required List<int> SeatIds { get; set; }
        public double AmountPaid { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;
    }
}
