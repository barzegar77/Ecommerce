namespace Ecommerce.Models.Shipping
{
    public partial class ShipmentDeliveredEvent
    {
        public Shipment Shipment { get; }
        public ShipmentDeliveredEvent(Shipment shipment)
        {
            Shipment = shipment;
        }
        
    }
}