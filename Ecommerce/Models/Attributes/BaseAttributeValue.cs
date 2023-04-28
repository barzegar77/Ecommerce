using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Attributes
{ 
    public abstract partial class BaseAttributeValue
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }
        public int AttributeId { get; set; }
    }
}
