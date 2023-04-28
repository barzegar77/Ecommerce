using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Catalog
{
    public partial class CategoryTemplate 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ViewPath { get; set; }

        public int DisplayOrder { get; set; }
    }
}
