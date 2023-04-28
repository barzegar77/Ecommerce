namespace Ecommerce.Models.Orders
{
    public partial class OrderAuthorizedEvent
    {
        public Order Order { get; }
        public OrderAuthorizedEvent(Order order)
        {
            Order = order;
        }
        
    }
}
