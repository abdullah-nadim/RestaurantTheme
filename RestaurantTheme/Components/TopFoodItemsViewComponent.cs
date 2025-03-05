using Microsoft.AspNetCore.Mvc;
using RestaurantTheme.Services;

namespace RestaurantTheme.Components
{
    public class TopFoodItemsViewComponent : ViewComponent
    {
        private readonly FoodService _foodService;

        public TopFoodItemsViewComponent()
        {
            _foodService = new FoodService();
        }
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var books = await _foodService.GetTopPicksAsync(count);
            return View(books);
        }
    }
}
