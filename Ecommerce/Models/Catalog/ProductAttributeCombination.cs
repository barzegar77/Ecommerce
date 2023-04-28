using Ecommerce.Models.Media;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductAttributeCombination 
    {
        [Key]
        public int Id { get; set; }

        public string AttributesXml { get; set; }
        public int StockQuantity { get; set; }
        public bool AllowOutOfStockOrders { get; set; }
        public string? Sku { get; set; }
        public string? ManufacturerPartNumber { get; set; }
        public string? Gtin { get; set; }
        public decimal? OverriddenPrice { get; set; }
        public int NotifyAdminForQuantityBelow { get; set; }
        public int MinStockQuantity { get; set; }


        #region rel

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int PictureId { get; set; }
        [ForeignKey(nameof(PictureId))]
        public Picture Picture { get; set; }

        #endregion
    }
}
