namespace Domain.Entities
{
    public class PaymentInfo : EntityBase
    {
        #region Order
        public Order Order { get; set; }
        public string OrderItemId { get; set; } = string.Empty;

        #endregion
        public DateTime PaidOn { get; set; }
        public string PaymentType { get; set; }
    }
}
