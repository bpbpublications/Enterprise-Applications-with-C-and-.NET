using BookingService.Server.Logic;
using BookingService.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;
        private readonly CountryLogic _countryLogic;
        public CountryController(ILogger<CountryController> logger)
        {
            _logger = logger;
            _countryLogic = new CountryLogic();
        }

        [HttpGet]
        public async Task<List<Country>> GetList()
        {
            return await _countryLogic.GetList();
        }

        [HttpGet]
        public async Task<Country> Get(int id)
        {
            return await _countryLogic.Get(id);
        }

        [HttpPost]
        public async Task Add([FromBody] Country country)
        {
            await _countryLogic.Add(country);
        }

        [HttpPost]
        public async Task Edit([FromBody] Country country)
        {
            await _countryLogic.Edit(country);
        }
    }
}


