namespace Ecommerce.Models.Catalog
{
    public enum ManageInventoryMethod
    {
        /// <summary>
        /// Don't track inventory for product
        /// </summary>
        DontManageStock = 0,

        /// <summary>
        /// Track inventory for product
        /// </summary>
        ManageStock = 1,

        /// <summary>
        /// Track inventory for product by product attributes
        /// </summary>
        ManageStockByAttributes = 2,
    }
}
