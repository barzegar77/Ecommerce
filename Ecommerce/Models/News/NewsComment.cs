namespace Ecommerce.Models.News
{
    public partial class NewsComment
    {
        public int Id { get; set; }

        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public int NewsItemId { get; set; }
        public int CustomerId { get; set; }
        public bool IsApproved { get; set; }
        public int StoreId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }
    }
}