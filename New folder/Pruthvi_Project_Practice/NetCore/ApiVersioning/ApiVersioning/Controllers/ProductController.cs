using ApiVersioning.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [Route("api/product")]
    [ApiController]
    [ApiVersion("1.0",Deprecated = true)]
    [ApiVersion("2.0")]
    public class ProductController : ControllerBase
    {
        [HttpGet("{id}")]
        [MapToApiVersion("1.0")]
        public IActionResult GetProduct(int id)
        {
            var product = new Product()
            {
                ID = id,
                Name = "Gear Box",
                Description = "Gear Box - Description"
            };

            return Ok(product);
        }

        [HttpGet("{id}")]
        [MapToApiVersion("2.0")]
        public IActionResult GetProductV2(int id)
        {
            var product = new Product()
            {
                ID = id,
                Name = "Gear Box(V2.0)",
                Description = "Gear Box - Description"
            };

            return Ok(product);
        }
    }
}
