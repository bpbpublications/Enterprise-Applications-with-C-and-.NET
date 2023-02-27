using BookingService.Server.Data;
using BookingService.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Server.Logic
{
    public class CustomerLogic
    {
        private readonly SystemContext _systemContext;

        public CustomerLogic()
        {
            _systemContext = new SystemContext();
        }

        public async Task<List<Customer>> GetList()
        {
            var customers = await _systemContext.Customer
                .Include(x => x.Country)
                .ToListAsync();

            return customers;
        }

        public async Task<Customer> Get(int id)
        {
            var customer = await _systemContext.Customer
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();

            return customer;
        }

        public async Task Add(Customer customer)
        {
            customer.Country = null;
            await _systemContext.Customer.AddAsync(customer);
            await _systemContext.SaveChangesAsync();
        }

        public async Task Edit(Customer customer)
        {
            customer.Country = null;
            _systemContext.Customer.Update(customer);
            await _systemContext.SaveChangesAsync();
        }
    }
}


