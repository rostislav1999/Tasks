using Microsoft.AspNetCore.Mvc;
using PizzaApp.Repositories;
using PizzaApp.Models;
using NLog;
using NLog.Config;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzaRepository _pizzaRepository;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger(); // Логгер

        // Конструктор с внедрением зависимости PizzaRepository
        public PizzaController(PizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository ?? throw new ArgumentNullException(nameof(pizzaRepository));
        }

        // Метод Index
        public IActionResult Index()
        {
            Logger.Info("Запрошена страница со списком пицц (Index)");
            var pizzas = _pizzaRepository.GetAllPizzas();
            Logger.Info($"Найдено {pizzas.Count} пицц(ы)");
            return View(pizzas);
        }

        // Новый метод IndexNew
        public IActionResult IndexNew()
        {
            Logger.Info("Запрошена страница IndexNew");
            var pizzas = _pizzaRepository.GetAllPizzas();
            Logger.Info($"Найдено {pizzas.Count} пицц(ы)");
            return View(pizzas);
        }

        // Метод Detail
        public IActionResult Detail(int id)
        {
            Logger.Info($"Запрошена информация о пицце с ID: {id}");
            var pizza = _pizzaRepository.GetPizzaById(id);
            if (pizza == null)
            {
                Logger.Warn($"Пицца с ID {id} не найдена.");
                return NotFound("Пицца не найдена.");
            }

            Logger.Info($"Пицца с ID {id} успешно найдена: {pizza.Name}");
            return View(pizza);
        }

        public IActionResult GetDetails(int id)
        {
            Logger.Info($"Получение данных о пицце через AJAX с ID: {id}");
            var pizza = _pizzaRepository.GetPizzaById(id);
            if (pizza == null)
            {
                Logger.Warn($"Пицца с ID {id} не найдена.");
                return NotFound();
            }

            Logger.Info($"Пицца с ID {id} успешно найдена: {pizza.Name}");
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
            Logger.Info($"Получение пиццы по ID: {id}");
            var pizza = _pizzaRepository.FindById(id);
            if (pizza == null)
            {
                Logger.Warn($"Пицца с ID {id} не найдена.");
                return NotFound("Пицца не найдена.");
            }

            Logger.Info($"Пицца с ID {id} успешно найдена: {pizza.Name}");
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