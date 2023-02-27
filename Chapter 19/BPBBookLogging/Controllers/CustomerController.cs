using Microsoft.AspNetCore.Mvc;

namespace BPBBookLogging.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
    

        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Customer> GetCustomers()
        {
            _logger.LogInformation($"Get Customers method was executed at : {DateTime.UtcNow}");

            return new List<Customer>();
        }
    }
}