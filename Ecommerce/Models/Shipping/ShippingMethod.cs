namespace Ecommerce.Models.Shipping
{
    public partial class ShippingMethod 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
    }
}