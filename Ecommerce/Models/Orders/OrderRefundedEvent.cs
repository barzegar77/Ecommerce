
namespace Ecommerce.Models.Orders
{
    public partial class OrderRefundedEvent
    {
        public Order Order { get; }
        public decimal Amount { get; }
        public OrderRefundedEvent(Order order, decimal amount)
        {
            Order = order;
            Amount = amount;
        }
        
    }
}