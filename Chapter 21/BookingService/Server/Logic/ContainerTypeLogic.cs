using BookingService.Server.Data;
using BookingService.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Server.Logic
{
    public class ContainerTypeLogic
    {
        private readonly SystemContext _systemContext;

        public ContainerTypeLogic()
        {
            _systemContext = new SystemContext();
        }

        public async Task<List<ContainerType>> GetList()
        {
            var containertype = await _systemContext.ContainerType.ToListAsync();
            return containertype;
        }

        public async Task<ContainerType> Get(int id)
        {
            var containerType = await _systemContext.ContainerType
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();
            return containerType;
        }

        public async Task Add(ContainerType containerType)
        {
            await _systemContext.ContainerType.AddAsync(containerType);
            await _systemContext.SaveChangesAsync();
        }

        public async Task Edit(ContainerType containerType)
        {
            _systemContext.ContainerType.Update(containerType);
            await _systemContext.SaveChangesAsync();
        }
    }
}
