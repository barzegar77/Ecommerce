using Ecommerce.Models.Customers;
using Ecommerce.Models.Stores;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductReview
    {
        [Key]
        public int Id { get; set; }

       

        /// <summary>
        /// Gets or sets a value indicating whether the content is approved
        /// </summary>
        public bool IsApproved { get; set; }

        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the review text
        /// </summary>
        public string ReviewText { get; set; }

        /// <summary>
        /// Gets or sets the reply text
        /// </summary>
        public string ReplyText { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the customer is already notified of the reply to review
        /// </summary>
        public bool CustomerNotifiedOfReply { get; set; }

        /// <summary>
        /// Review rating
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Review helpful votes total
        /// </summary>
        public int HelpfulYesTotal { get; set; }

        /// <summary>
        /// Review not helpful votes total
        /// </summary>
        public int HelpfulNoTotal { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }


        #region rel

        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int StoreId { get; set; }
        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; }

        #endregion
    }
}
