namespace Domain.Entities
{
    public class Invoice : EntityBase
    {
        public string OrderId { get; set; }
        public string PaymentId { get; set; }
    }
}
