using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaApp.Repositories;
using TestTaskTwo.Models;

namespace TestTaskTwo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PizzaRepository _pizzaRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _pizzaRepository = new PizzaRepository();
        }

        public IActionResult Index()
        {
            var pizzas = _pizzaRepository.GetAllPizzas();

            return View(pizzas);
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
}
