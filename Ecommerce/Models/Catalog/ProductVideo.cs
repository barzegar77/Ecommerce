using Ecommerce.Models.Media;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductVideo
    {
        [Key]
        public int Id { get; set; }
        public int DisplayOrder { get; set; }

        #region rel

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }


        public int VideoId { get; set; }
        [ForeignKey(nameof(VideoId))]
        public Video Video { get; set; }

        #endregion
    }
}
