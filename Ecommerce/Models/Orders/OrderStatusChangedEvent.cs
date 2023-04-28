namespace Ecommerce.Models.Orders
{
    public partial class OrderStatusChangedEvent
    {
        public Order Order { get; }
        public OrderStatus PreviousOrderStatus { get; set; }
        public OrderStatusChangedEvent(Order order, OrderStatus previousOrderStatus)
        {
            Order = order;
            PreviousOrderStatus = previousOrderStatus;
        }
        
    }
}