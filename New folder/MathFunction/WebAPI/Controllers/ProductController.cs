using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Model;
using WebAPI.Models;
using WebAPI.Services;
using System.Linq;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController( IProductService productService) 
        {
            _productService = productService;
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = _productService.GetProductById(id);
            if(result == null) 
                return NotFound();
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllProduct()
        {
            var result = _productService.GetAllProducts();
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task AddProduct(Product product)
        {
            _productService.AddProduct(product);
        }
    }
}
