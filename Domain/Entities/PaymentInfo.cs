namespace Domain.Entities
{
    public class PaymentInfo : EntityBase
    {
        public string OrderId { get; set; }
        public DateTime PaidOn { get; set; }
        public string InvoiceId { get; set; }
    }
}
