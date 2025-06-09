using Order.Models;

namespace Order.Services
{
    public interface IOrderService 
    {
        void Post(OrderModel orderModel);
    }
}
