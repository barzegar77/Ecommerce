namespace Ecommerce.Models.Blogs
{
    public partial class BlogCommentApprovedEvent
    {
        public BlogCommentApprovedEvent(BlogComment blogComment)
        {
            BlogComment = blogComment;
        }
        public BlogComment BlogComment { get; }
    }
}