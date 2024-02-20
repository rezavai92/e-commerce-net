using System.Diagnostics.CodeAnalysis;

namespace Domain.Entities
{
    public class Customer : EntityBase
    {
        #region User
        public required User User { get; set; } 

        public required string UserItemId { get; set; }

        #endregion

        #region Order
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        #endregion

        #region Billing Location
        public Location? BillingLocation { get; set; }
        public string? BillingLocationItemId { get; set; }
        #endregion

        #region Shopping Cart
        public ShoppingCart? ShoppingCart { get; set; }
        #endregion


    }
}
