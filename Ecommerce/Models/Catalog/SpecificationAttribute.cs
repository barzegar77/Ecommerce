using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class SpecificationAttribute 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public int? SpecificationAttributeGroupId { get; set; }
        [ForeignKey("SpecificationAttributeGroupId")]
        public SpecificationAttributeGroup SpecificationAttributeGroup { get; set; }
    }
}
