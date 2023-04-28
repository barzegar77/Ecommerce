namespace Ecommerce.Models.Gdpr
{
    public enum GdprRequestType
    {
        ConsentAgree = 1,
        ConsentDisagree = 5,
        ExportData = 10,
        DeleteCustomer = 15,
        ProfileChanged = 20
    }
}
