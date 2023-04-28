using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Catalog
{
    public partial class RelatedProduct
    {
        [Key]
        public int Id { get; set; }

        public int ProductId1 { get; set; }
        public int ProductId2 { get; set; }
        
        public int DisplayOrder { get; set; }
    }
}
