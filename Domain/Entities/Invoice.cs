namespace Domain.Entities
{
    public class Invoice : EntityBase
    {
        public Order Order { get; set; }
        public string OrderItemId { get; set; } = string.Empty;
        
    }
}
