namespace Domain.Entities
{
    public class ShoppingCart : EntityBase
    {
        public string CustomerId { get; set; }
        public IEnumerable<string> ProductIds { get; set; } = new List<string>();
    }
}
