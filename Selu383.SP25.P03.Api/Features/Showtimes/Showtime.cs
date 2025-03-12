using Selu383.SP25.P03.Api.Features.Theaters;
using System.ComponentModel.DataAnnotations.Schema;

namespace Selu383.SP25.P03.Api.Features.Showtimes
{
    public class Showtime
    {

        public int Id { get; set; }
        public TimeOnly Time { get; set; }
        //the actual time (8:00 pm, 2:00 pm)
        public DateOnly ShowDate { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public string Format { get; set; }
        //formats like 3D, 2D, IMAX, etc.
        public bool Available { get; set; }
        //

    }
}
