namespace Ecommerce.Models.Security
{
    public partial class AclRecord 
    {
        public int Id { get; set; }

        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public int CustomerRoleId { get; set; }
    }
}
