
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductReviewReviewTypeMapping
    {
        [Key]
        public int Id { get; set; }

        public int Rating { get; set; }

        #region rel

        public int ProductReviewId { get; set; }
        [ForeignKey(nameof(ProductReviewId))]
        public ProductReview ProductReview { get; set; }


        public int ReviewTypeId { get; set; }
        [ForeignKey(nameof(ReviewTypeId))]
        public ReviewType ReviewType { get; set; }

        #endregion
    }
}
