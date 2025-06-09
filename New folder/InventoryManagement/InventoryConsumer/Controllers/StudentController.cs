using FluentValidation.AspNetCore;
using InventoryConsumer.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryConsumer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        public StudentController() 
        { 
        
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] StudentDto studentDto)
        {
            var validator = new StudentDtoValidation();
            var result = validator.Validate(studentDto);
            return Ok();
        }
    }
}
