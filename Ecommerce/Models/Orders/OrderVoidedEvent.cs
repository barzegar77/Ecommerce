namespace Ecommerce.Models.Orders
{
    public partial class OrderVoidedEvent
    {
        public Order Order { get; }
        public OrderVoidedEvent(Order order)
        {
            Order = order;
        }
    }
}