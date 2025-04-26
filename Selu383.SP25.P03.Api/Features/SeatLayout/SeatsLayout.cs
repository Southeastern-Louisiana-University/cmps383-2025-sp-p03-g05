using Selu383.SP25.P03.Api.Features.Theaters;
using Selu383.SP25.P03.Api.Features.Tickets;

namespace Selu383.SP25.P03.Api.Features.SeatLayout
{
    public class Seat
    {
        public int Id { get; set; }
        public string Row { get; set; } // e.g., A, B, C
        public int Number { get; set; } // e.g., 1, 2, 3
        public bool IsAvailable { get; set; } = true;

        public int TheaterId { get; set; }
        public Theater Theater { get; set; }


        public ICollection<Ticket> Tickets { get; set; }
    }
}
