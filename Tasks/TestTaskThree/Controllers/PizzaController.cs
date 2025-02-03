using Microsoft.AspNetCore.Mvc;
using PizzaApp.Repositories;
using PizzaApp.Models;
using NLog;
using System.Threading.Tasks;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzaRepository _pizzaRepository;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public PizzaController(PizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository ?? throw new ArgumentNullException(nameof(pizzaRepository));
        }

        // GET: Pizza
        public async Task<IActionResult> Index()
        {
            try
            {
                Logger.Info("Запрошена страница со списком пицц (Index)");
                var pizzas = await _pizzaRepository.GetAllPizzasAsync();
                Logger.Info($"Успешно получено {pizzas.Count} пицц");
                return View(pizzas);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ошибка при получении списка пицц");
                return StatusCode(500, "Внутренняя ошибка сервера");
            }
        }

        // GET: Pizza/IndexNew
        public async Task<IActionResult> IndexNew()
        {
            try
            {
                Logger.Info("Запрошена страница IndexNew");
                var pizzas = await _pizzaRepository.GetAllPizzasAsync();
                Logger.Info($"Успешно получено {pizzas.Count} пицц для IndexNew");
                return View(pizzas);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ошибка в методе IndexNew");
                return StatusCode(500, "Внутренняя ошибка сервера");
            }
        }

        // GET: Pizza/Detail/5
        public async Task<IActionResult> Detail(int id)
        {
            try
            {
                Logger.Info($"Запрос деталей пиццы с ID: {id}");
                var pizza = await _pizzaRepository.GetPizzaByIdAsync(id);

                if (pizza == null)
                {
                    Logger.Warn($"Пицца с ID {id} не найдена");
                    return NotFound("Пицца не найдена");
                }

                Logger.Info($"Успешно найдена пицца: {pizza.Name} (ID: {pizza.Id})");
                return View(pizza);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, $"Ошибка при получении пиццы с ID: {id}");
                return StatusCode(500, "Внутренняя ошибка сервера");
            }
        }

        // GET: Pizza/GetDetails/5
        [HttpGet]
        public async Task<IActionResult> GetDetails(int id)
        {
            try
            {
                Logger.Info($"AJAX запрос деталей пиццы с ID: {id}");
                var pizza = await _pizzaRepository.GetPizzaByIdAsync(id);

                if (pizza == null)
                {
                    Logger.Warn($"Пицца с ID {id} не найдена (AJAX)");
                    return NotFound();
                }

                Logger.Info($"Успешно обработан AJAX запрос для пиццы: {pizza.Name}");
                return Json(new
                {
                    name = pizza.Name,
                    ingredients = pizza.Ingredients,
                    price = pizza.Price.ToString("C2"),
                    image = Url.Content($"~/img/{System.IO.Path.GetFileName(pizza.Image)}")
                });
            }
            catch (Exception ex)
            {
                Logger.Error(ex, $"Ошибка при обработке AJAX запроса для ID: {id}");
                return StatusCode(500, new { error = "Internal server error" });
            }
        }

        // GET: Pizza/GetPizzaById/5
        [HttpGet]
        public async Task<IActionResult> GetPizzaById(int id)
        {
            try
            {
                Logger.Info($"Запрос пиццы по ID: {id}");
                var pizza = await _pizzaRepository.FindByIdAsync(id);

                if (pizza == null)
                {
                    Logger.Warn($"Пицца с ID {id} не найдена");
                    return NotFound("Пицца не найдена");
                }

                Logger.Info($"Успешно возвращена пицца: {pizza.Name}");
                return Json(new
                {
                    id = pizza.Id,
                    name = pizza.Name,
                    ingredients = pizza.Ingredients,
                    price = pizza.Price.ToString("C2"),
                    image = Url.Content($"~/img/{System.IO.Path.GetFileName(pizza.Image)}")
                });
            }
            catch (Exception ex)
            {
                Logger.Error(ex, $"Ошибка при получении пиццы по ID: {id}");
                return StatusCode(500, new { error = "Internal server error" });
            }
        }
    }
}