using Ecommerce.Models.Catalog;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductSpecificationAttribute
    {
        [Key]
        public int Id { get; set; }

        public int AttributeTypeId { get; set; }
        public string? CustomValue { get; set; }
        public bool AllowFiltering { get; set; }
        public bool ShowOnProductPage { get; set; }
        public int DisplayOrder { get; set; }

        public SpecificationAttributeType AttributeType
        {
            get => (SpecificationAttributeType)AttributeTypeId;
            set => AttributeTypeId = (int)value;
        }

        #region rel
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int SpecificationAttributeOptionId { get; set; }
        [ForeignKey("SpecificationAttributeOptionId")]
        public SpecificationAttributeOption SpecificationAttributeOption { get; set; }

        #endregion
    }
}
