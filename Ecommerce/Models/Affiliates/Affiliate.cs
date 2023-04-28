using Ecommerce.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Affiliates
{
    public partial class Affiliate
    {
        [Key]
        public int Id { get; set; }
        
        public string AdminComment { get; set; }
        public string FriendlyUrlName { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }

        #region rel
        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        #endregion
    }
}
