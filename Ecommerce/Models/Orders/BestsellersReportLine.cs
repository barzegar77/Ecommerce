namespace Ecommerce.Models.Orders
{
    [Serializable]
    public partial class BestsellersReportLine
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalQuantity { get; set; }
    }
}
