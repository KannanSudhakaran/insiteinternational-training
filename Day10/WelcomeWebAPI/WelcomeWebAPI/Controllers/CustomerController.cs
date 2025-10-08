using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WelcomeWebAPI.Models;
using WelcomeWebAPI.Services;

namespace WelcomeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetCustomers() { 
        
         
            CustomerDataServcie servcie = new CustomerDataServcie();

            return Ok(servcie.GetCustomerData());

        }
    }
}
