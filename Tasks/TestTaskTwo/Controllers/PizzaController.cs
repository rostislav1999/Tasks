using Microsoft.AspNetCore.Mvc;
using PizzaApp.Repositories;  // Подключаем репозиторий
using PizzaApp.Models;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzaRepository _pizzaRepository;

        // Конструктор с внедрением зависимостей
        public PizzaController()
        {
            _pizzaRepository = new PizzaRepository();  // Можно внедрить через DI контейнер, если требуется
        }

        // Метод Index
        public IActionResult Index()
        {
            // Получаем список всех пицц из репозитория
            var pizzas = _pizzaRepository.GetAllPizzas();

            // Передаем список пицц в представление
            return View(pizzas);
        }
    }
}