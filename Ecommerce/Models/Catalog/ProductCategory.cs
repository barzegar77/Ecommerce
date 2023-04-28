using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        public bool IsFeaturedProduct { get; set; }
        public int DisplayOrder { get; set; }


        #region rel
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]    
        public Category Category { get; set; }

        #endregion
    }
}
