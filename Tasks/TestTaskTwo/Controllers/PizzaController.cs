using Microsoft.AspNetCore.Mvc;
using PizzaApp.Repositories;
using PizzaApp.Models;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzaRepository _pizzaRepository;

        public PizzaController(PizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public IActionResult GetPizzas(List<int> ids)
        {
            var pizzas = _pizzaRepository.FindByIds(ids); // Проверить, что метод FindByIds не выбрасывает исключение
            return View(pizzas);
        }
    }
}