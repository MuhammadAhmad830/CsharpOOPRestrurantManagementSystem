namespace RestaurantManagementSystem.BL
{
    public class Item
    {
        public string Name;
        public decimal OriginalPrice;  // Original price of the item
        public decimal DiscountPrice;  // This is the calculated discounted price
        public string Category;
        public int Stock;
        public decimal Discount;  // Discount percentage, e.g., 10 for 10%

        // Constructor for initializing Item
        public Item(string name, decimal originalPrice, string category, int stock, decimal discount)
        {
            Name = name;
            OriginalPrice = originalPrice;
            Category = category;
            Stock = stock;
            Discount = discount;
            DiscountPrice = CalculateDiscountedPrice();  // Automatically calculate discount price when item is created
        }

        // Virtual method to calculate discounted price, which can be overridden
        public virtual decimal CalculateDiscountedPrice()
        {
            // If there is a discount, calculate the discounted price
            return OriginalPrice - (OriginalPrice * (Discount / 100));
        }
    }
}

