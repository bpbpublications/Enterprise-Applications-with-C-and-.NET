namespace BPBBookChapter19.Models
{
    public interface IBookingManager
    {
        Task<string> SendBookingAsync(BookingOrder bookingOrder);
    }
}


