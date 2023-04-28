using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class PredefinedProductAttributeValue
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }

        public decimal PriceAdjustment { get; set; }
        public bool PriceAdjustmentUsePercentage { get; set; }
        public decimal WeightAdjustment { get; set; }
        public decimal Cost { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }


        #region rel
        public int ProductAttributeId { get; set; }
        [ForeignKey(nameof(ProductAttributeId))]
        public ProductAttribute ProductAttribute { get; set; }
        #endregion
    }
}
