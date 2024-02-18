namespace Domain.Entities
{
    public class Order : EntityBase
    {
        public string PrductId { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderedOn { get; set; }
        public DateTime DeliveredOn { get; set; }
        public string ApprovedByUserId { get; set; }
        public string PaymentType { get; set; }
        public string PaymentId { get; set; }
        public string InvoiceId { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public string CouponId { get; set; }
    }
}
