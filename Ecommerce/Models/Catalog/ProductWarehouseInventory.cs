using Ecommerce.Models.Shipping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductWarehouseInventory 
    {
        [Key]
        public int Id { get; set; }

        public int StockQuantity { get; set; }
        public int ReservedQuantity { get; set; }


        #region rel
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int WarehouseId { get; set; }
        [ForeignKey(nameof(WarehouseId))]
        public Warehouse Warehouse { get; set; }

        #endregion
    }
}
