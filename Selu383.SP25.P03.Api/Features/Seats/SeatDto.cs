namespace Selu383.SP25.P03.Api.Features.Seats
{
    public class SeatDto
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public bool IsTaken { get; set; }
    }
}
