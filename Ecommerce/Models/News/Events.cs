namespace Ecommerce.Models.News
{
    public partial class NewsCommentApprovedEvent
    {
        public NewsCommentApprovedEvent(NewsComment newsComment)
        {
            NewsComment = newsComment;
        }

        /// <summary>
        /// News comment
        /// </summary>
        public NewsComment NewsComment { get; }
    }
}