namespace Domain.Entities
{
    public class Product : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public string CategoryId { get; set; }
        public double Price { get; set; }
        public string PrimaryImageUrl { get; set; }
        public IEnumerable<string> SecondaryImageUrls { get; set; }
        public long RemainingQuantity { get; set; }

    }
}
