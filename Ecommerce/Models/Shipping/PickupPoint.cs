﻿namespace Ecommerce.Models.Shipping
{
    public partial class PickupPoint
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProviderSystemName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string StateAbbreviation { get; set; }
        public string CountryCode { get; set; }
        public string ZipPostalCode { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public decimal PickupFee { get; set; }
        public string OpeningHours { get; set; }
        public int DisplayOrder { get; set; }
        public int? TransitDays { get; set; }
    }
}
