using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using Microsoft.AspNetCore.Authorization;
using BPBWebApi.Filters;
using BPBWebApi.Models;

namespace BPBWebApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly IJwtAuthenticator _jwtAuthenticator;
        public CustomerController(IJwtAuthenticator jwtAuthenticator)
        {
            _jwtAuthenticator = jwtAuthenticator;
        }

        public IActionResult Authenticate(User user)
        {
            try
            {
                var token = _jwtAuthenticator.Authenticate(user);
                return Ok(token);
            }
            catch(UnauthorizedAccessException ex)
            {
                return Unauthorized();
            }
            catch(Exception ex)
            {
                return Problem();
            }
           
        }

        [HttpGet]
        [AllowAnonymous]
        public Customer GetCustomer(int id)
        {
            return new Customer() { Id = id };
        }

        [Authorize(Roles = "Sales")]
        public Customer GetRestrictedCustomer(int id)
        {
            var customer = new Customer() { Id = id };
            return customer;
        }

        [CustomerAuthorizationFilter]
        public List<Customer> GetCustomers()
        {
            return new List<Customer>();
        }


        private void SetPrincipal(IPrincipal principal)
        {
            Thread.CurrentPrincipal = principal;
            if (HttpContext.Request != null)
            {
                GenericIdentity userIdentity = new GenericIdentity(principal.Identity.Name);
                GenericPrincipal userPrincipal = new GenericPrincipal(userIdentity, null);

                HttpContext.User = userPrincipal;
            }
        }
    }
}