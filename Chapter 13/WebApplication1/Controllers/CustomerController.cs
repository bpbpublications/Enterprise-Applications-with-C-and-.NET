using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CustomerController : ControllerBase
    {
        private static List<Customer> _customerList = new List<Customer>()
        {
            new Customer() { Id = 1, Firstname = "Alex", Lastname = "Malavasi", BirthDay = new DateTime(1987, 12,1)},
            new Customer() { Id = 2, Firstname = "Myla", Lastname = "Belle", BirthDay = new DateTime(1993, 5, 23)},
            new Customer() { Id = 2, Firstname = "Paula", Lastname = "Chevete", BirthDay = new DateTime(1965, 4, 10)}

        };
        public IActionResult Index()
        {
            return Ok(_customerList);
        }

        [HttpGet(Name = "GetCustomer")]
        public IActionResult GetCustomer(int id)
        {
            var customer = _customerList.FirstOrDefault(x => x.Id == id);

            if (customer == null) return NotFound();

            return Ok(customer);
        }


        [HttpPost(Name = "AddCustomer")]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerList.Add(customer);
            return Ok(customer);
        }
    }
}
