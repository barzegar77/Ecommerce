namespace Ecommerce.Models.Shipping
{
    /// <summary>
    /// Represents the shipping status enumeration
    /// </summary>
    public enum ShippingStatus
    {
        ShippingNotRequired = 10,
        NotYetShipped = 20,
        PartiallyShipped = 25,
        Shipped = 30,
        Delivered = 40
    }
}
