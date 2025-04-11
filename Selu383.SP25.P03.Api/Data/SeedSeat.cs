namespace Selu383.SP25.P03.Api.Data
{
    public static class SeedSeats
    {
        public static void Initialize(DataContext context) 
        {
            if (context.Seats.Any()) return;

            var seats = new List<Seats>();

            var rows = new[] { "A", "B", "C", "D", "E" }; 
            int seatsPerRow = 10;

            foreach (var row in rows)
            {
                for (int i = 1; i <= seatsPerRow; i++)
                {
                    seats.Add(new Seats
                    {
                        Row = row,
                        Col = i,
                        IsTaken = false,
                        TheaterId = 1 
                    });
                }
            }

            context.Seats.AddRange(seats);
            context.SaveChanges();
        }
    }
}
