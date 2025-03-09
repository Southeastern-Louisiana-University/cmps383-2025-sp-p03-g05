namespace Selu383.SP25.P03.Api.Features.Tickets
{
    public class TicketDto
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public List<int> SeatIds { get; set; }
        public double AmountPaid { get; set; }
        public string Email { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
