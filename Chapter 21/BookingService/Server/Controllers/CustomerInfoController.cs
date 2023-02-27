using BookingService.Server.Logic;
using BookingService.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CustomerInfoController : ControllerBase
    {
        private readonly ILogger<CustomerInfoController> _logger;
        private readonly CustomerLogic _customerLogic;
        public CustomerInfoController(ILogger<CustomerInfoController> logger)
        {
            _logger = logger;
            _customerLogic = new CustomerLogic();
        }

        [HttpGet]
        public async Task<List<Customer>> GetList()
        {
            return await _customerLogic.GetList();
        }

        [HttpGet]
        public async Task<Customer> Get(int id)
        {
            return await _customerLogic.Get(id);
        }

        [HttpPost]
        public async Task Add([FromBody] Customer customer)
        {
            await _customerLogic.Add(customer);
        }

        [HttpPost]
        public async Task Edit([FromBody] Customer customer)
        {
            await _customerLogic.Edit(customer);
        }
    }
}


