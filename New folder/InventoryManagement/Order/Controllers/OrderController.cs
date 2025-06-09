using Microsoft.AspNetCore.Mvc;
using Order.Models;
using Order.Services;

namespace Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly IOrderService _orderService;
        public readonly IConfiguration _configuration;

        public OrderController(IOrderService orderService, IConfiguration configuration)
        {
            _orderService = orderService;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task Post([FromBody] OrderModel orderModel)
        {
            if(ModelState.IsValid)
            {
                _orderService.Post(orderModel);
            }
        }
    }
}
