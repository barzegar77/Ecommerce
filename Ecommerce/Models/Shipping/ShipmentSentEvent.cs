namespace Ecommerce.Models.Shipping
{
    public partial class ShipmentSentEvent
    {
        public Shipment Shipment { get; }
        public ShipmentSentEvent(Shipment shipment)
        {
            Shipment = shipment;
        }
        
    }
}