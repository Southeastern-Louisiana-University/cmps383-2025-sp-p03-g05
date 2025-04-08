using Selu383.SP25.P03.Api.Features.Theaters;
using System.ComponentModel.DataAnnotations.Schema;

namespace Selu383.SP25.P03.Api.Features.Showtimes
{
    public class Showtime
    {

        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        [ForeignKey("Theater")]
        public int TheaterId { get; set; }
        public string Format { get; set; }
        //formats like 3D, 2D, IMAX, etc.
        public bool Available { get; set; }
        //

    }
}
