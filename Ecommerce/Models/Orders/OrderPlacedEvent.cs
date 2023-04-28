
namespace Ecommerce.Models.Orders
{
    public partial class OrderPlacedEvent
    {
        public Order Order { get; }
        public OrderPlacedEvent(Order order)
        {
            Order = order;
        }
        
    }
}