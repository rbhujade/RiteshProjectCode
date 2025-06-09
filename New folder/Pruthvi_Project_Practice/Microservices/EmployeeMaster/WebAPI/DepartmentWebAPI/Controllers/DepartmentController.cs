using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public DepartmentController()
        {
        }

        [HttpGet]
        public List<string> Get()
        {
            var deptList = new List<string> { "IT", "Account", "HR" };
            return deptList;
        }
    }
}
