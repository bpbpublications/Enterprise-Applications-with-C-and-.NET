namespace BPBBookChapter19.Models
{
    public class BookingOrder
    {
        public int CustomerNumber { get; set; }
        public DateTime Date { get; set; }
        public string? AirportOrigin { get; set; }
        public string? AirportDestination { get; set; }
        public decimal Price { get; set; }
    }
}

