using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Authentication Successfull.");
        }
    }
}
