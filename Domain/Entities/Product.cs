namespace Domain.Entities
{
    public class Product : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
       
        public double Price { get; set; }
        public string PrimaryImageUrl { get; set; }
        public IEnumerable<string> SecondaryImageUrls { get; set; } = new List<string>();
        public long RemainingQuantity { get; set; }
      
        //public string CategoryId { get; set; }
        public ICollection<ProductCategory> Categories { get; set; }

        #region Brand
        public string BrandItemId { get; set; }
        public Brand Brand { get; set; }
        #endregion

        public ICollection<Order> CustomerOrders { get; set; }

        #region Shopping Cart
        public ICollection<ShoppingCart> ShoppingCarts { get; set; }
        #endregion

    }
}
