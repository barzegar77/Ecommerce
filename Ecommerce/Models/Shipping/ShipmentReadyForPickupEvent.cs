namespace Ecommerce.Models.Shipping
{
    public partial class ShipmentReadyForPickupEvent
    {
        public Shipment Shipment { get; }
        public ShipmentReadyForPickupEvent(Shipment shipment)
        {
            Shipment = shipment;
        }
        
    }
}
