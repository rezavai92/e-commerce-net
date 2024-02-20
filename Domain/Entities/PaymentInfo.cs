namespace Domain.Entities
{
    public class PaymentInfo : EntityBase
    {
        #region Order
        public required Order Order { get; set; }
        public required string OrderItemId { get; set; }

        #endregion
        public DateTime PaidOn { get; set; }
        public required string PaymentType { get; set; }
    }
}
