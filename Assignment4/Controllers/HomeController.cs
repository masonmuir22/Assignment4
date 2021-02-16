using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment4.Models;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> topRestaurantList = new List<string>(); //Make the list object string

            

            foreach (Top_Restaurants r in Top_Restaurants.GetTop_Restaurants())
            {
                string link = r.Web_Link ?? "Coming Soon";
                string dish = r.Favorite_Dish ?? "It's all tasty";

                topRestaurantList.Add($"#{r.Rank}: {r.Restaurant_Name}, Favorite Dish: {dish}, Address: {r.Address}, Phone: {r.Restaurant_Phone}, Web Link: {link}"); //This works because we put static in the variable. Makes it belong to the class
            }

 

            return View(topRestaurantList); //pass it into the view
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Suggestions()
        {
            return View(TempStorage.Restaurants);
        }


        [HttpGet]
        public IActionResult Suggestions_Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggestions_Form(Suggestion restaurant)
        {

            if (ModelState.IsValid)
            {
                TempStorage.AddSuggestion(restaurant);
                return View("Suggestions", TempStorage.Restaurants); //we want to go to the suggestions list when we press enter on the form
            }
            else
            {
                return View(restaurant);
            }

            
            
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
