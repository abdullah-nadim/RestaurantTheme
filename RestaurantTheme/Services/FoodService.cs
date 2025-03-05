using RestaurantTheme.Models;

namespace RestaurantTheme.Services
{
    public class FoodService
    {
        public List<FoodItem> GetFoodItems()
        {
            return new List<FoodItem>
            {
                new FoodItem { Id = 1, Name = "Chicken Biryani", Price = 250.00m, Category = "Main Course" },
                new FoodItem { Id = 2, Name = "Grilled Chicken", Price = 400.00m, Category = "Main Course" },
                new FoodItem { Id = 3, Name = "Mutton Kebab", Price = 350.00m, Category = "Appetizer" },
                new FoodItem { Id = 4, Name = "Paneer Butter Masala", Price = 220.00m, Category = "Vegetarian" },
                new FoodItem { Id = 5, Name = "French Fries", Price = 120.00m, Category = "Snacks" },
                new FoodItem { Id = 6, Name = "Chocolate Brownie", Price = 180.00m, Category = "Dessert" },
                new FoodItem { Id = 7, Name = "Mango Lassi", Price = 90.00m, Category = "Beverage" }
            };
        }

        public async Task<List<FoodItem>> GetTopPicksAsync(int count)
        {
            var foodItems = GetFoodItems();

            // You can implement any logic here to get "top picks", like by sorting or filtering.
            // For now, just take the top 'count' items.
            var topPicks = foodItems.Take(count).ToList();

            // Simulating an async operation
            await Task.Delay(100); // Simulating async work, e.g., fetching data from a database or API.

            return topPicks;
        }
    }
}
