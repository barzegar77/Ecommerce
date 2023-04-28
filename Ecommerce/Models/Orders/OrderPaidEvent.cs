namespace Ecommerce.Models.Orders
{
    public partial class OrderPaidEvent
    {
        public Order Order { get; }
        public OrderPaidEvent(Order order)
        {
            Order = order;
        }
     
    }
}