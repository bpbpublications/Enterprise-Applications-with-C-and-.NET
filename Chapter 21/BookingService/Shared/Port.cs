namespace BookingService.Shared
{
    public class Port
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; } = new Country();
    }
}


