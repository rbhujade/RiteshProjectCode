using InventoryConsumer.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryConsumer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        public readonly ILogger _logger;

        public InventoryController(ILogger logger) 
        { 
            _logger = logger;
        }

        [HttpPost]
        public IActionResult ProcessInventoryUpdate([FromBody] InventoryUpdateRequest request)
        {
            return Ok("Inventory update processed successfully.");
        }
    }
}
