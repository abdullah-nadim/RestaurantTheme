using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RestaurantTheme.Models;
using RestaurantTheme.Services;

namespace RestaurantTheme.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly FoodService _foodService;

    public HomeController(ILogger<HomeController> logger)
    {
        _foodService = new FoodService();
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<FoodItem> foodItems = _foodService.GetFoodItems();
        return View(foodItems);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
