using Microsoft.AspNetCore.Mvc;
using PizzaApp.Repositories;
using PizzaApp.Models;

namespace PizzaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly PizzaRepository _pizzaRepository;

        public HomeController(PizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public IActionResult Index()
        {
            var pizzas = _pizzaRepository.GetAllPizzas(); // Убедитесь, что этот метод вызывается
            return View(pizzas);
        }
        public IActionResult Privacy()
        {
            var pizzas = _pizzaRepository.GetAllPizzas(); // Убедитесь, что этот метод вызывается
            return View(pizzas);
        }

        public IActionResult Detail(int id)
        {
            var pizza = _pizzaRepository.GetPizzaById(id);
            if (pizza == null)
            {
                return NotFound("Пицца не найдена.");
            }

            return View(pizza);
        }
    }
}