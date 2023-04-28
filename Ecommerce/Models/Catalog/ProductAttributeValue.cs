using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductAttributeValue
    {
        [Key]
        public int Id { get; set; }

        public int AttributeValueTypeId { get; set; }

        public int AssociatedProductId { get; set; }

        [Required]
        public string Name { get; set; }
        public string? ColorSquaresRgb { get; set; }

        /// <summary>
        /// Gets or sets the picture ID for image square (used with "Image squares" attribute type)
        /// </summary>
        public int ImageSquaresPictureId { get; set; }

        /// <summary>
        /// Gets or sets the price adjustment (used only with AttributeValueType.Simple)
        /// </summary>
        public decimal PriceAdjustment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether "price adjustment" is specified as percentage (used only with AttributeValueType.Simple)
        /// </summary>
        public bool PriceAdjustmentUsePercentage { get; set; }

        /// <summary>
        /// Gets or sets the weight adjustment (used only with AttributeValueType.Simple)
        /// </summary>
        public decimal WeightAdjustment { get; set; }

        /// <summary>
        /// Gets or sets the attribute value cost (used only with AttributeValueType.Simple)
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the customer can enter the quantity of associated product (used only with AttributeValueType.AssociatedToProduct)
        /// </summary>
        public bool CustomerEntersQty { get; set; }

        /// <summary>
        /// Gets or sets the quantity of associated product (used only with AttributeValueType.AssociatedToProduct)
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the value is pre-selected
        /// </summary>
        public bool IsPreSelected { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the picture (identifier) associated with this value. This picture should replace a product main picture once clicked (selected).
        /// </summary>
        public int PictureId { get; set; }

        /// <summary>
        /// Gets or sets the attribute value type
        /// </summary>
        public AttributeValueType AttributeValueType
        {
            get => (AttributeValueType)AttributeValueTypeId;
            set => AttributeValueTypeId = (int)value;
        }


        #region rel

        public int ProductAttributeMappingId { get; set; }
        [ForeignKey(nameof(ProductAttributeMappingId))]
        public ProductAttributeMapping ProductAttributeMapping { get; set; }
        #endregion
    }
}
