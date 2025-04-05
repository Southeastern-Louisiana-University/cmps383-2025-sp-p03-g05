using static Selu383.SP25.P03.Api.Features.Showtimes.Showtime;

namespace Selu383.SP25.P03.Api.Features.Showtimes
{
    public class ShowtimeDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public string Format { get; set; }
        //formats like 3D, 2D, IMAX, etc.
        public bool Available { get; set; }

    }

    public class ShowtimesGetDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public string Format { get; set; }
        //formats like 3D, 2D, IMAX, etc.
        public bool Available { get; set; }

    }

    public class ShowtimeCreateDto
    {
        public DateTime StartTime { get; set; }
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public string Format { get; set; }
        //formats like 3D, 2D, IMAX, etc.
        public bool Available { get; set; }

    }

    public class ShowtimeUpdateDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public string Format { get; set; }
        //formats like 3D, 2D, IMAX, etc.
        public bool Available { get; set; }

    }
}

