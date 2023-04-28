namespace Ecommerce.Models.Shipping
{
    public partial class ShippingMethodCountryMapping
    {
        public int Id { get; set; }
        public int ShippingMethodId { get; set; }
        public int CountryId { get; set; }
    }
}