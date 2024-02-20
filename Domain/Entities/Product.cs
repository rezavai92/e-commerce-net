namespace Domain.Entities
{
    public class Product : EntityBase
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public required string ProductCode { get; set; } 
       
        public double Price { get; set; }
        public string? PrimaryImageUrl { get; set; }
        public IList<string>? SecondaryImageUrls { get; set; } = new List<string>();
        public long RemainingQuantity { get; set; }
      
        public  ICollection<ProductCategory>? Categories { get; set; }

        #region Brand
        public string? BrandItemId { get; set; }
        public Brand? Brand { get; set; }
        #endregion

        #region Order
        public ICollection<Order>? CustomerOrders { get; set; }
        #endregion

        #region Shopping Cart
        public ICollection<ShoppingCart>? ShoppingCarts { get; set; }
        #endregion

    }
}
