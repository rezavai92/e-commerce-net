namespace Domain.Entities
{
    public class ShippingInfo : EntityBase
    {
        public string OrderId { get; set; }
        public string BillingLocationId { get; set; }
        public string Status { get; set; }
        public long TrackingNumber { get; set; }
        public long Method { get; set; }
    }
}
