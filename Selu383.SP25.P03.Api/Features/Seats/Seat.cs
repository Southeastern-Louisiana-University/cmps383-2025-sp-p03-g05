using Selu383.SP25.P03.Api.Features.Theaters;

namespace Selu383.SP25.P03.Api.Features.Seats
{
    public class Seat
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public required string Row { get; set; } = string.Empty;
        public required int Col { get; set; }
        public bool IsTaken { get; set; } = false;

        public virtual Theater? Theater { get; set; }
    }
}





