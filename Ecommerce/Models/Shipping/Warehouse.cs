namespace Ecommerce.Models.Shipping
{
    public partial class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AdminComment { get; set; }
        public int AddressId { get; set; }
    }
}