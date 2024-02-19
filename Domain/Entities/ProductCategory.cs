namespace Domain.Entities
{
    public class ProductCategory : EntityBase
    {
        public string Category { get; set; }
        public string Alias { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
