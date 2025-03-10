using Selu383.SP25.P03.Api.Features.Theaters;
using System.ComponentModel.DataAnnotations;

namespace Selu383.SP25.P03.Api.Features.Seats
{
    public class Seat
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public required int Row { get; set; }
        public required int Col { get; set; }
        public bool IsTaken { get; set; } = false;

        public virtual Theater? Theater { get; set; }
    }
}





