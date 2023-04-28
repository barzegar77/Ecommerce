using Ecommerce.Models.Customers;
using Ecommerce.Models.Stores;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class BackInStockSubscription
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime CreatedOnUtc { get; set; }


        #region rel
        public int StoreId { get; set; }
        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; }

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        #endregion
    }
}
