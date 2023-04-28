﻿namespace Ecommerce.Models.Common
{
    public partial class SitemapSettings
    {
        public bool SitemapEnabled { get; set; }
        public int SitemapPageSize { get; set; }
        public bool SitemapIncludeBlogPosts { get; set; }
        public bool SitemapIncludeCategories { get; set; }
        public bool SitemapIncludeManufacturers { get; set; }
        public bool SitemapIncludeNews { get; set; }
        public bool SitemapIncludeProducts { get; set; }
        public bool SitemapIncludeProductTags { get; set; }
        public bool SitemapIncludeTopics { get; set; }
    }
}
