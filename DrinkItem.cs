namespace RestaurantManagementSystem.BL
{
    public class DrinkItem : Item
    {
        public DrinkItem(string name, decimal originalPrice, string category, int stock, decimal discount)
            : base(name, originalPrice, category, stock, discount)
        {
        }

        // Override for drink-specific discount logic if needed
        public override decimal CalculateDiscountedPrice()
        {
            // This can be modified for more complex drink-specific discount logic
            return OriginalPrice - (OriginalPrice * (Discount / 100));
        }
    }
}

