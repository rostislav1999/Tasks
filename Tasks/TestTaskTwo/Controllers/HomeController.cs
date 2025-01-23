using Microsoft.AspNetCore.Mvc;
using PizzaApp.Repositories;
using PizzaApp.Models;

namespace TestTaskTwo.Controllers
{
    public class HomeController : Controller
    {
        private readonly PizzaRepository _pizzaRepository;

        public HomeController()
        {
            _pizzaRepository = new PizzaRepository();
        }

        
        [HttpGet]
        public IActionResult GetPizzas()
        {
            var pizzas = _pizzaRepository.GetAllPizzas();
            return Json(pizzas);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}