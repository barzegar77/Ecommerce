using Ecommerce.Models.Customers;
using Ecommerce.Models.Stores;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Blogs
{
    public partial class BlogComment
    {
        [Key]
        public int Id { get; set; }
        public string CommentText { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        #region rel

        public int StoreId { get; set; }
        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        public int BlogPostId { get; set; }
        [ForeignKey(nameof(BlogPostId))]
        public BlogPost BlogPost { get; set; }

        #endregion
    }
}