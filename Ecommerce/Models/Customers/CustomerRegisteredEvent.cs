namespace Ecommerce.Models.Customers
{
    public partial class CustomerRegisteredEvent
    {

        public CustomerRegisteredEvent(Customer customer)
        {
            Customer = customer;
        }
        public Customer Customer
        {
            get;
        }
    }
}