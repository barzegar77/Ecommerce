using Ecommerce.Models.Catalog;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Attributes
{
    public abstract partial class BaseAttribute
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }


        public AttributeControlType AttributeControlType
        {
            get => (AttributeControlType)AttributeControlTypeId;
            set => AttributeControlTypeId = (int)value;
        }

        public bool ShouldHaveValues
        {
            get
            {
                if (AttributeControlType == AttributeControlType.TextBox ||
                    AttributeControlType == AttributeControlType.MultilineTextbox ||
                    AttributeControlType == AttributeControlType.Datepicker ||
                    AttributeControlType == AttributeControlType.FileUpload)
                    return false;

                //other attribute control types support values
                return true;
            }
        }

        public bool CanBeUsedAsCondition
        {
            get
            {
                if (AttributeControlType == AttributeControlType.ReadonlyCheckboxes ||
                    AttributeControlType == AttributeControlType.TextBox ||
                    AttributeControlType == AttributeControlType.MultilineTextbox ||
                    AttributeControlType == AttributeControlType.Datepicker ||
                    AttributeControlType == AttributeControlType.FileUpload)
                    return false;

                //other attribute control types support it
                return true;
            }
        }
    }
}
