namespace Ecommerce.Models.Vendors
{
    public partial class VendorNote
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string Note { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}
