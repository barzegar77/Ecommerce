using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductManufacturer 
    {
        [Key]
        public int Id { get; set; }
        public bool IsFeaturedProduct { get; set; }
        public int DisplayOrder { get; set; }

        #region rel
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int ManufacturerId { get; set; }
        [ForeignKey(nameof(ManufacturerId))]
        public Manufacturer Manufacturer { get; set; }
        #endregion
    }
}
