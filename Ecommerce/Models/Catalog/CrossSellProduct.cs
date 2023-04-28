namespace Ecommerce.Models.Catalog
{
    public partial class CrossSellProduct
    {
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the first product identifier
        /// </summary>
        public int ProductId1 { get; set; }

        /// <summary>
        /// Gets or sets the second product identifier
        /// </summary>
        public int ProductId2 { get; set; }
    }
}
