namespace Ecommerce.Models.Common
{
    public partial class AdminAreaSettings
    {
        public int DefaultGridPageSize { get; set; }
        public int PopupGridPageSize { get; set; }
        public string GridPageSizes { get; set; }
        public string RichEditorAdditionalSettings { get; set; }
        public bool RichEditorAllowJavaScript { get; set; }
        public bool RichEditorAllowStyleTag { get; set; }
        public bool UseRichEditorForCustomerEmails { get; set; }
        public bool UseRichEditorInMessageTemplates { get; set; }
        public bool HideAdvertisementsOnAdminArea { get; set; }
        public bool CheckLicense { get; set; }
        public string LastNewsTitleAdminArea { get; set; }
        public bool UseIsoDateFormatInJsonResult { get; set; }
        public bool ShowDocumentationReferenceLinks { get; set; }
    }
}