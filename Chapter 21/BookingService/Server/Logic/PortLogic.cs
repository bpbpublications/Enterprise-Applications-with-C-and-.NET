using BookingService.Server.Data;
using BookingService.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Server.Logic
{
    public class PortLogic
    {
        private readonly SystemContext _systemContext;

        public PortLogic()
        {
            _systemContext = new SystemContext();
        }

        public async Task<List<Port>> GetList()
        {
            var ports = await _systemContext.Port
                .Include(x => x.Country)
                .ToListAsync();

            return ports;
        }

        public async Task<Port> Get(int id)
        {
            var port = await _systemContext.Port
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();
            return port;
        }

        public async Task Add(Port port)
        {
            port.Country = null;
            await _systemContext.Port.AddAsync(port);
            await _systemContext.SaveChangesAsync();
        }

        public async Task Edit(Port port)
        {
            port.Country = null;
            _systemContext.Port.Update(port);
            await _systemContext.SaveChangesAsync();
        }
    }
}


