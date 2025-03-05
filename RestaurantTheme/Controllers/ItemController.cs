using Microsoft.AspNetCore.Mvc;
using RestaurantTheme.Services;

namespace RestaurantTheme.Controllers
{
    public class ItemController : Controller
    {
        private readonly FoodService _foodService;

        public ItemController()
        {
            _foodService = new FoodService();
        }

        public IActionResult Index()
        {
            var foodItems = _foodService.GetFoodItems();
            return View(foodItems);
        }


    }
}
