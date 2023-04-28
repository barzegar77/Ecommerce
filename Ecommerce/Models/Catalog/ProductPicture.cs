using Ecommerce.Models.Media;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductPicture 
    {
        [Key]
        public int Id { get; set; }
        public int DisplayOrder { get; set; }

        #region rel
        public int PictureId { get; set; }
        [ForeignKey(nameof(PictureId))]
        public Picture Picture { get; set; }

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))] 
        public Product Product { get; set; }

        #endregion
    }
}
