using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductProductTagMapping 
    {
        [Key]
        public int Id { get; set; }
        
        
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }


        public int ProductTagId { get; set; }
        [ForeignKey(nameof(ProductTagId))]
        public ProductTag ProductTag { get; set; }
    }
}