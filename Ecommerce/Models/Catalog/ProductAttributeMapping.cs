using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Catalog
{
    public partial class ProductAttributeMapping
    {
        [Key]
        public int Id { get; set; }

        public string TextPrompt { get; set; }
        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }
        public int AttributeControlTypeId { get; set; }
        public AttributeControlType AttributeControlType
        {
            get => (AttributeControlType)AttributeControlTypeId;
            set => AttributeControlTypeId = (int)value;
        }


        //validation fields

        /// <summary>
        /// Gets or sets the validation rule for minimum length (for textbox and multiline textbox)
        /// </summary>
        public int? ValidationMinLength { get; set; }

        /// <summary>
        /// Gets or sets the validation rule for maximum length (for textbox and multiline textbox)
        /// </summary>
        public int? ValidationMaxLength { get; set; }

        /// <summary>
        /// Gets or sets the validation rule for file allowed extensions (for file upload)
        /// </summary>
        public string ValidationFileAllowedExtensions { get; set; }

        /// <summary>
        /// Gets or sets the validation rule for file maximum size in kilobytes (for file upload)
        /// </summary>
        public int? ValidationFileMaximumSize { get; set; }

        /// <summary>
        /// Gets or sets the default value (for textbox and multiline textbox)
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets a condition (depending on other attribute) when this attribute should be enabled (visible).
        /// Leave empty (or null) to enable this attribute.
        /// Conditional attributes that only appear if a previous attribute is selected, such as having an option 
        /// for personalizing clothing with a name and only providing the text input box if the "Personalize" radio button is checked.
        /// </summary>
        public string ConditionAttributeXml { get; set; }


        #region rel

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int ProductAttributeId { get; set; }
        [ForeignKey(nameof(ProductAttributeId))]
        public ProductAttribute ProductAttribute { get; set; }

        #endregion
    }
}