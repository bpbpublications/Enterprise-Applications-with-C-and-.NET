namespace BPBBookChapter19.Models
{
    public interface IBookingSender
    {
        Task<string> SendAsync(BookingOrder bookingOrder);
    }
}

