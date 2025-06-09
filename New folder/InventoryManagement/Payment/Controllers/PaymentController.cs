using Microsoft.AspNetCore.Mvc;
using Payment.Models;
using Payment.Services;

namespace Payment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        public readonly IPaymentService _paymentService;

        [HttpGet]
        public async Task<OrderModel> Get()
        {
            OrderModel result = new OrderModel();
            return result;
        }
    }
}
