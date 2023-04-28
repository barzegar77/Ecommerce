namespace Ecommerce.Models.Customers
{
    public partial class CustomerCustomerRoleMapping
    {
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the customer role identifier
        /// </summary>
        public int CustomerRoleId { get; set; }
    }
}