namespace BPBBookChapter19.Models
{
    public class BookingManager : IBookingManager
    {
        private readonly IBookingSender _bookingSender;

        public BookingManager(IBookingSender bookingSender)
        {
            _bookingSender = bookingSender;
        }

        public async Task<string> SendBookingAsync(BookingOrder bookingOrder)
        {
           
            return await _bookingSender.SendAsync(bookingOrder);
        }
    }
}



