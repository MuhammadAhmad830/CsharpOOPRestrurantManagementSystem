namespace RestaurantManagementSystem.BL
{
    public class FoodItem : Item
    {
        public FoodItem(string name, decimal originalPrice, string category, int stock, decimal discount)
            : base(name, originalPrice, category, stock, discount)
        {
        }

        // Override for food-specific discount logic if needed
        public override decimal CalculateDiscountedPrice()
        {
            // This can be modified for more complex food-specific discount logic
            return OriginalPrice - (OriginalPrice * (Discount / 100));
        }
    }
}

