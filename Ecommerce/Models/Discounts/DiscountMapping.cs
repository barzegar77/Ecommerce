namespace Ecommerce.Models.Discounts
{
    public abstract partial class DiscountMapping
    {
        public int DiscountId { get; set; }
        public abstract int EntityId { get; set; }
    }
}
