using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] StudentDto studentDto)
        //{
        //    var validator = new StudentDtoValidation();
        //    var result = validator.Validate(studentDto);
        //    return Ok();
        //}
    }
}
