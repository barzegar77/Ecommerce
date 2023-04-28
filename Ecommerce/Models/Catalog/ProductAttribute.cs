using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductAttribute 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
