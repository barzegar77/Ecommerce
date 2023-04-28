namespace Ecommerce.Models.Customers
{
    public partial class CustomerLoggedOutEvent
    {
        public CustomerLoggedOutEvent(Customer customer)
        {
            Customer = customer;
        }
        public Customer Customer { get; }
    }
}