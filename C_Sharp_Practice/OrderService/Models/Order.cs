namespace OrderService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public decimal Amount { get; set; }
    }
}
