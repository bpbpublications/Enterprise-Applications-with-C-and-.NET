namespace BookingService.Shared
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; } = new Country();
        public string Notes { get; set; }
        public bool Active { get; set; }

    }
}

