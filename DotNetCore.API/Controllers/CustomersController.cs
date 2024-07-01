using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.API.Controllers
{
    //https://localhost:portnumber/api/customers
    [Route("v1/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok( "mdu");
        }
    }
}
