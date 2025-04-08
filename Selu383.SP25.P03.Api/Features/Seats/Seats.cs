using Selu383.SP25.P03.Api.Features.Theaters;

public class Seats
{
    public int Id { get; set; }
    public int TheaterId { get; set; }
    public required string Row { get; set; }
    public required int Col { get; set; }
    public bool IsTaken { get; set; } = false;
    public int Number { get; set; } 

    public virtual Theater? Theater { get; set; }
}
