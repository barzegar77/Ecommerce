using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class StockQuantityHistory 
    {
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Gets or sets the stock quantity adjustment
        /// </summary>
        public int QuantityAdjustment { get; set; }

        /// <summary>
        /// Gets or sets current stock quantity
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// Gets or sets the message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }


        /// <summary>
        /// Gets or sets the product attribute combination identifier
        /// </summary>
        public int? CombinationId { get; set; }

        /// <summary>
        /// Gets or sets the warehouse identifier
        /// </summary>
        public int? WarehouseId { get; set; }


        #region rel
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        #endregion
    }
}
