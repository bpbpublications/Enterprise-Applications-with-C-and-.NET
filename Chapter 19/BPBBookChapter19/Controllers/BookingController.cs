using BPBBookChapter19.Models;
using Microsoft.AspNetCore.Mvc;

namespace BPBBookChapter19.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {


        private readonly IBookingManager _bookingManager;

        public BookingController(IBookingManager bookingManager)
        {
            _bookingManager = bookingManager; 
        }

        [HttpPost]
        public async Task<string> RegisterBooking(BookingOrder bookingOrder)
        {
            return await _bookingManager.SendBookingAsync(bookingOrder);
        }
    }
}



