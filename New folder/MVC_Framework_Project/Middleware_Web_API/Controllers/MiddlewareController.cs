using Microsoft.AspNetCore.Mvc;


namespace Middleware_Web_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MiddlewareController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Emp> emps = new List<Emp>()
            {
                new Emp
                {
                    Name = "Test" , Description ="Test desc"
                },
                new Emp
                {
                    Name = "Test2" , Description ="Test desc2"
                }
            };
            return Ok(emps);
        }

        public class Emp
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
}
