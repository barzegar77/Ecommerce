namespace Ecommerce.Models.Security
{
    public partial class PermissionRecordCustomerRoleMapping
    {
        public int Id { get; set; }
        public int PermissionRecordId { get; set; }
        public int CustomerRoleId { get; set; }
    }
}