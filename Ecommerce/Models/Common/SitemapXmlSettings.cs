﻿namespace Ecommerce.Models.Common
{
    public partial class SitemapXmlSettings
    {
        public List<string> SitemapCustomUrls { get; set; }
        public SitemapXmlSettings()
        {
            SitemapCustomUrls = new List<string>();
        }

        public bool SitemapXmlEnabled { get; set; }
        public bool SitemapXmlIncludeBlogPosts { get; set; }
        public bool SitemapXmlIncludeCategories { get; set; }
        public bool SitemapXmlIncludeCustomUrls { get; set; }
        public bool SitemapXmlIncludeManufacturers { get; set; }
        public bool SitemapXmlIncludeNews { get; set; }
        public bool SitemapXmlIncludeProducts { get; set; }
        public bool SitemapXmlIncludeProductTags { get; set; }
        public bool SitemapXmlIncludeTopics { get; set; }
        public int RebuildSitemapXmlAfterHours { get; set; }
        public int SitemapBuildOperationDelay { get; set; }
    }
}