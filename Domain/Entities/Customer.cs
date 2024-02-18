namespace Domain.Entities
{
    public class Customer : EntityBase
    {
        public string UserId { get; set; }
        public Location BillingAddress { get; set; }
    }
}
