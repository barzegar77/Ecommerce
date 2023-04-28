using Ecommerce.Models.Media;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class Manufacturer 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public string? MetaKeywords { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaTitle { get; set; }

        
        public int PageSize { get; set; }
        public bool AllowCustomersToSelectPageSize { get; set; }
        public string? PageSizeOptions { get; set; }
        public bool SubjectToAcl { get; set; }
        public bool LimitedToStores { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public bool PriceRangeFiltering { get; set; }
        public decimal PriceFrom { get; set; }
        public decimal PriceTo { get; set; }
        public bool ManuallyPriceRange { get; set; }


        #region rel
        public int PictureId { get; set; }
        [ForeignKey(nameof(PictureId))]
        public Picture Picture { get; set; }


        public int ManufacturerTemplateId { get; set; }
        [ForeignKey(nameof(ManufacturerTemplateId))]
        public ManufacturerTemplate ManufacturerTemplate { get; set; }

        #endregion
    }
}