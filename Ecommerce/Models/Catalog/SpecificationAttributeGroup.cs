using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Catalog
{
    public partial class SpecificationAttributeGroup 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
