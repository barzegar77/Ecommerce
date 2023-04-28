namespace Ecommerce.Models.Gdpr
{
    public partial class CustomerPermanentlyDeleted
    {
        public CustomerPermanentlyDeleted(int customerId, string email)
        {
            CustomerId = customerId;
            Email = email;
        }

        public int CustomerId { get; }
        public string Email { get; }
    }
}