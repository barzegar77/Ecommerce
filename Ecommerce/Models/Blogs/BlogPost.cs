using Ecommerce.Models.Localization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Blogs
{
    public partial class BlogPost
    {
        [Key]
        public int Id { get; set; }

        public bool IncludeInSitemap { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        public string BodyOverview { get; set; }
        public bool AllowComments { get; set; }
        public string Tags { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
        public string? MetaKeywords { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaTitle { get; set; }
        public bool LimitedToStores { get; set; }
        public DateTime CreatedOnUtc { get; set; }



        #region rel
        public int LanguageId { get; set; }
        [ForeignKey(nameof(LanguageId))]
        public Language Language { get; set; }

        #endregion

    }
}