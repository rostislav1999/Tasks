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

        // Метод для отображения списка всех пицц
        public IActionResult Index()
        {
            var pizzas = _pizzaRepository.GetAllPizzas(); // Убедитесь, что этот метод вызывается
            return View(pizzas);
        }

        // Новый метод IndexNew
        public IActionResult IndexNew()
        {
            var pizzas = _pizzaRepository.GetAllPizzas(); // Или используйте другие методы для фильтрации данных
            return View(pizzas); // Отображение пицц на новой странице
        }

        // Метод для отображения деталей пиццы по её ID
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