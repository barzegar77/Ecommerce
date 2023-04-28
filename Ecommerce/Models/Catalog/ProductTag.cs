using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductTag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}