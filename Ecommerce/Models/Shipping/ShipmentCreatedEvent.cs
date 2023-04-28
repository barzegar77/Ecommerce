namespace Ecommerce.Models.Shipping
{
    public partial class ShipmentCreatedEvent
    {
        public Shipment Shipment { get; }
        public ShipmentCreatedEvent(Shipment shipment)
        {
            Shipment = shipment;
        }
    }
}