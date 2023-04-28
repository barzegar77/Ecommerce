﻿namespace Ecommerce.Models.Discounts
{
    /// <summary>
    /// Represents a discount-category mapping class
    /// </summary>
    public partial class DiscountCategoryMapping : DiscountMapping
    {
        /// <summary>
        /// Gets or sets the category identifier
        /// </summary>
        public override int EntityId { get; set; }
    }
}