using Microsoft.AspNetCore.Mvc;
using PizzaApp.PizzaRepositories;
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

        public IActionResult Index()
        {
            var pizzas = _pizzaRepository.GetAllPizzas();
            return View("~/Views/Home/Index.cshtml", pizzas);
        }

        // Метод для отображения деталей пиццы
        public IActionResult Detail(int id)
        {
            var pizza = _pizzaRepository.FindById(id);
            if (pizza == null)
            {
                return NotFound(); // Возвращаем 404, если пицца не найдена
            }
            return View("~/Views/Home/Detail.cshtml", pizza); // Передаем объект пиццы в представление
        }
    }
}