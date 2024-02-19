namespace Domain.Entities
{
    public class ShoppingCart : EntityBase
    {
        #region Customer
        public Customer Customer { get; set; } =new Customer();
        public string CustomerItemId { get; set; } = string.Empty;  
        #endregion

        #region Product
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
        #endregion
    }
}
