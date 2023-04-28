using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductReviewHelpfulness
    {
        [Key]
        public int Id { get; set; }
       
        public bool WasHelpful { get; set; }
        public int CustomerId { get; set; }


        #region rel

        public int ProductReviewId { get; set; }
        [ForeignKey(nameof(ProductReviewId))]
        public ProductReview ProductReview { get; set; }

        #endregion
    }
}
