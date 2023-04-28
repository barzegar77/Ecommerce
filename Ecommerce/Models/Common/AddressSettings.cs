﻿namespace Ecommerce.Models.Common
{
    public partial class AddressSettings
    {
        public bool CompanyEnabled { get; set; }
        public bool CompanyRequired { get; set; }
        public bool StreetAddressEnabled { get; set; }
        public bool StreetAddressRequired { get; set; }
        public bool StreetAddress2Enabled { get; set; }
        public bool StreetAddress2Required { get; set; }
        public bool ZipPostalCodeEnabled { get; set; }
        public bool ZipPostalCodeRequired { get; set; }
        public bool CityEnabled { get; set; }
        public bool CityRequired { get; set; }
        public bool CountyEnabled { get; set; }
        public bool CountyRequired { get; set; }
        public bool CountryEnabled { get; set; }
        public int? DefaultCountryId { get; set; }
        public bool StateProvinceEnabled { get; set; }
        public bool PhoneEnabled { get; set; }
        public bool PhoneRequired { get; set; }
        public bool FaxEnabled { get; set; }
        public bool FaxRequired { get; set; }
        public bool PreselectCountryIfOnlyOne { get; set; }
    }
}