namespace Ecommerce.Models.Common
{
    public partial class PdfSettings
    {
        public int LogoPictureId { get; set; }
        public bool LetterPageSizeEnabled { get; set; }
        public bool RenderOrderNotes { get; set; }
        public bool DisablePdfInvoicesForPendingOrders { get; set; }
        public string FontFamily { get; set; }
        public string InvoiceFooterTextColumn1 { get; set; }
        public string InvoiceFooterTextColumn2 { get; set; }
    }
}