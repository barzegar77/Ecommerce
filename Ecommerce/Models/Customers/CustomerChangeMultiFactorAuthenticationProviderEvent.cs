namespace Ecommerce.Models.Customers
{
    public partial class CustomerChangeMultiFactorAuthenticationProviderEvent
    {
        public Customer Customer { get; }
        public CustomerChangeMultiFactorAuthenticationProviderEvent(Customer customer)
        {
            Customer = customer;
        }
       
    }
}
