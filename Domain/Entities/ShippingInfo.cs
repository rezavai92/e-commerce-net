namespace Domain.Entities
{
    public class ShippingInfo : EntityBase
    {

        #region Order

        public ICollection<Order> CustomerOrders { get; set; } 
      
        #endregion

        #region Billing Location
        public Location BillingLocation { get; set; } = new Location();
        public string BillingLocationItemId { get; set; } = string.Empty;
        #endregion 

        public string Status { get; set; } = string.Empty;
        public string TrackingNumber { get; set; } = string.Empty;
        public string ShippingMethod { get; set; } = string.Empty;
    }
}
