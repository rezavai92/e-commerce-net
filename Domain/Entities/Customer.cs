namespace Domain.Entities
{
    public class Customer : EntityBase
    {
        #region User
        public User User  { get; set; }

        public string UserItemId { get; set; }

        #endregion

        #region Order
        public ICollection<Order> Orders { get; set; }
        #endregion

        #region Billing Location
        public Location? BillingLocation { get; set; }
        public string? BillingLocationItemId { get; set; }
        #endregion

        #region Shopping Cart
        public ShoppingCart ShoppingCart { get; set; } = new ShoppingCart();
        #endregion


    }
}
