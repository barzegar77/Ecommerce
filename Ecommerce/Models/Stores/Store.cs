namespace Ecommerce.Models.Stores
{
    public partial class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DefaultMetaKeywords { get; set; }
        public string DefaultMetaDescription { get; set; }
        public string DefaultTitle { get; set; }
        public string HomepageTitle { get; set; }
        public string HomepageDescription { get; set; }
        public string Url { get; set; }
        public bool SslEnabled { get; set; }
        public string Hosts { get; set; }
        public int DefaultLanguageId { get; set; }
        public int DisplayOrder { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyVat { get; set; }
        public bool Deleted { get; set; }
    }
}
