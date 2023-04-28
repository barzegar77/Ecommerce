using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    
    public partial class SpecificationAttributeOption 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string? ColorSquaresRgb { get; set; }
        public int DisplayOrder { get; set; }

        #region rel

        public int SpecificationAttributeId { get; set; }
        [ForeignKey(nameof(SpecificationAttributeId))]
        public SpecificationAttribute SpecificationAttribute { get; set; }

        #endregion
    }
}
