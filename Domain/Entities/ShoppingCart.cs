namespace Domain.Entities
{
    public class ShoppingCart : EntityBase
    {
        #region Customer
        public required Customer Customer { get; set; } 
        public required string CustomerItemId { get; set; } 
        #endregion

        #region Product
        public ICollection<Product>? Products { get; set; } 
        #endregion
    }
}
