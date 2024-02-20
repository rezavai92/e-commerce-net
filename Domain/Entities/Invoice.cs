namespace Domain.Entities
{
    public class Invoice : EntityBase
    {
        public required Order Order { get; set; }
        public required string OrderItemId { get; set; } 
        
    }
}
