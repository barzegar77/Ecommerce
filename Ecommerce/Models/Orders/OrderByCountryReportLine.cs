namespace Ecommerce.Models.Orders
{
    public partial class OrderByCountryReportLine
    {
        public int? CountryId { get; set; }
        public int TotalOrders { get; set; }
        public decimal SumOrders { get; set; }
    }
}
