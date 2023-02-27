using BookingService.Server.Data;
using BookingService.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Server.Logic
{
    public class BookingLogic
    {
        private readonly SystemContext _systemContext;

        public BookingLogic()
        {
            _systemContext = new SystemContext();
        }

        public async Task<List<Booking>> GetList()
        {
            var bookings = await _systemContext.Booking
                .Include(x => x.Customer)
                .Include(x => x.PortOrigin)
                .Include(x => x.PortOrigin.Country)
                .Include(x => x.PortDestiny)
                .Include(x => x.PortDestiny.Country)
                .ToListAsync();

            return bookings;
        }

        public async Task<Booking> Get(int id)
        {
            var booking = await _systemContext.Booking
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();

            return booking;
        }

        public async Task Add(Booking booking)
        {
            booking.Customer = null;
            booking.PortOrigin = null;
            booking.PortDestiny = null;
            booking.ContainerType = null;

            await _systemContext.Booking.AddAsync(booking);
            await _systemContext.SaveChangesAsync();
        }

        public async Task Edit(Booking booking)
        {
            booking.Customer = null;
            booking.PortOrigin = null;
            booking.PortDestiny = null;
            booking.ContainerType = null;

            _systemContext.Booking.Update(booking);
            await _systemContext.SaveChangesAsync();
        }
    }
}




