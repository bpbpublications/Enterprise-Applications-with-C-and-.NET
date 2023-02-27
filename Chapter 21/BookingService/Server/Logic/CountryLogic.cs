using BookingService.Server.Data;
using BookingService.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Server.Logic
{
    public class CountryLogic
    {
        private readonly SystemContext _systemContext;

        public CountryLogic()
        {
            _systemContext = new SystemContext();
        }

        public async Task<List<Country>> GetList()
        {
            var countries = await _systemContext.Country.ToListAsync();
            return countries;
        }

        public async Task<Country> Get(int id)
        {
            var country = await _systemContext.Country
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();
            return country;
        }

        public async Task Add(Country country)
        {
            await _systemContext.Country.AddAsync(country);
            await _systemContext.SaveChangesAsync();
        }

        public async Task Edit(Country country)
        {
            _systemContext.Country.Update(country);
            await _systemContext.SaveChangesAsync();
        }
    }
}
