namespace Domain.Entities
{
    public class ShippingInfo : EntityBase
    {

        #region Order
        public required ICollection<Order> CustomerOrders { get; set; } 
        #endregion

        #region Billing Location
        public required Location BillingLocation { get; set; } 
        public required string BillingLocationItemId { get; set; } = string.Empty;
        #endregion 

        public required string Status { get; set; } 
        public required string TrackingNumber { get; set; } 
        public required string ShippingMethod { get; set; } 
    }
}
