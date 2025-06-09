using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController()
        {
        }

        [HttpGet]
        public List<string> GetAll()
        {
            var empList = new List<string> { "Raj", "Suresh", "Shaym" };
            return empList;
        }
    }
}
