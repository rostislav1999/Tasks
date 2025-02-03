using Microsoft.AspNetCore.Mvc;
using PizzaApp.Repositories;
using PizzaApp.Models;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzaRepository _pizzaRepository;

        // Конструктор с внедрением зависимости PizzaRepository
        public PizzaController(PizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository ?? throw new ArgumentNullException(nameof(pizzaRepository));
        }

        // Метод Index
        public IActionResult Index()
        {
            var pizzas = _pizzaRepository.GetAllPizzas();
            return View(pizzas);
        }

        // Новый метод IndexNew
        public IActionResult IndexNew()
        {
            var pizzas = _pizzaRepository.GetAllPizzas(); // Тот же код, что и в Index
            return View(pizzas);
        }

        // Метод Detail
        public IActionResult Detail(int id)
        {
            var pizza = _pizzaRepository.GetPizzaById(id);
            if (pizza == null)
            {
                return NotFound("Пицца не найдена.");
            }

            return View(pizza);
        }

        public IActionResult GetDetails(int id)
        {
            var pizza = _pizzaRepository.GetPizzaById(id);
            if (pizza == null)
            {
                return NotFound();
            }

            return Json(new
            {
                name = pizza.Name,
                ingredients = pizza.Ingredients,
                price = pizza.Price,
                image = Url.Content($"~/{pizza.Image}")
            });
        }

        public IActionResult GetPizzaById(int id)
        {
            var pizza = _pizzaRepository.FindById(id);  // Используйте метод FindById вместо GetPizzaById
            if (pizza == null)
            {
                return NotFound("Пицца не найдена.");
            }

            return Json(new
            {
                id = pizza.Id,
                name = pizza.Name,
                ingredients = pizza.Ingredients,
                price = pizza.Price,
                image = Url.Content($"~/{pizza.Image}")
            });
        }
    }
}