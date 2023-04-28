namespace Ecommerce.Models.Catalog
{
    public enum BackorderMode
    {
        NoBackorders = 0,
        AllowQtyBelow0 = 1,
        AllowQtyBelow0AndNotifyCustomer = 2,
    }
}
