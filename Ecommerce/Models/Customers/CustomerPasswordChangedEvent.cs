namespace Ecommerce.Models.Customers
{
    public partial class CustomerPasswordChangedEvent
    {
        public CustomerPassword Password { get; }
        public CustomerPasswordChangedEvent(CustomerPassword password)
        {
            Password = password;
        }
    }
}