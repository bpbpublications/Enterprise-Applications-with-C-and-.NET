namespace BookingService.Shared
{
    public class Booking
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public int ContainerTypeId { get; set; }
        public ContainerType ContainerType { get; set; } = new ContainerType();
        public int ContainerQuantity { get; set; }
        public DateTime EmbarkDate { get; set; }
        public DateTime ArrivalDate { get; set; }

        public int? PortOriginId { get; set; }
        public Port PortOrigin { get; set; } = new Port();
        public int? PortDestinyId { get; set; }
        public Port PortDestiny { get; set; } = new Port();
    }
}
