using BookingService.Server.Logic;
using BookingService.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BookingInfoController : ControllerBase
    {
        private readonly ILogger<BookingInfoController> _logger;
        private readonly BookingLogic _bookingLogic;
        public BookingInfoController(ILogger<BookingInfoController> logger)
        {
            _logger = logger;
            _bookingLogic = new BookingLogic();
        }

        [HttpGet]
        public async Task<List<Booking>> GetList()
        {
            return await _bookingLogic.GetList();
        }

        [HttpGet]
        public async Task<Booking> Get(int id)
        {
            return await _bookingLogic.Get(id);
        }

        [HttpPost]
        public async Task Add([FromBody] Booking booking)
        {
            await _bookingLogic.Add(booking);
        }

        [HttpPost]
        public async Task Edit([FromBody] Booking booking)
        {
            await _bookingLogic.Edit(booking);
        }
    }

}


