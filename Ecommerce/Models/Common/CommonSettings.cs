namespace Ecommerce.Models.Common
{
    public partial class CommonSettings
    {
        public List<string> IgnoreLogWordlist { get; set; }
        public CommonSettings()
        {
            IgnoreLogWordlist = new List<string>();
        }

        public bool SubjectFieldOnContactUsForm { get; set; }
        public bool UseSystemEmailForContactUsForm { get; set; }
        public bool DisplayJavaScriptDisabledWarning { get; set; }
        public bool Log404Errors { get; set; }
        public string BreadcrumbDelimiter { get; set; }
        public int ClearLogOlderThanDays { get; set; }
        public bool BbcodeEditorOpenLinksInNewWindow { get; set; }
        public bool PopupForTermsOfServiceLinks { get; set; }
        public bool JqueryMigrateScriptLoggingActive { get; set; }
        public bool UseResponseCompression { get; set; }
        public string FaviconAndAppIconsHeadCode { get; set; }
        public bool EnableHtmlMinification { get; set; }
        public int? RestartTimeout { get; set; }
        public string HeaderCustomHtml { get; set; }
        public string FooterCustomHtml { get; set; }
    }
}
