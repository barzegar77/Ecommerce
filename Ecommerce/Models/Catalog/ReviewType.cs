
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Catalog
{
    public partial class ReviewType 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool VisibleToAllCustomers { get; set; }
        public bool IsRequired { get; set; }
    }
}
