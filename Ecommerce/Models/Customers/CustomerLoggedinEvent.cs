namespace Ecommerce.Models.Customers
{
    public partial class CustomerLoggedinEvent
    {
        public CustomerLoggedinEvent(Customer customer)
        {
            Customer = customer;
        }
        public Customer Customer
        {
            get;
        }
    }
}