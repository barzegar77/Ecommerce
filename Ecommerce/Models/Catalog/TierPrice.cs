using Ecommerce.Models.Customers;
using Ecommerce.Models.Stores;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class TierPrice
    {
        [Key]
        public int Id { get; set; }

        
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public DateTime? StartDateTimeUtc { get; set; }

        public DateTime? EndDateTimeUtc { get; set; }


        #region rel

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int StoreId { get; set; }
        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; }

        public int? CustomerRoleId { get; set; }
        [ForeignKey(nameof(CustomerRoleId))]
        public CustomerRole CustomerRole { get; set; }

        #endregion
    }
}
