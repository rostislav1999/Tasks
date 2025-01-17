using Microsoft.AspNetCore.Mvc;
using PizzaApp.Repositories; // Репозиторий для работы с данными о пиццах
using TestTaskTwo.Models; // Модель для пиццы
using System.Collections.Generic;
using System.Diagnostics;

namespace TestTaskTwo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PizzaRepository _pizzaRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _pizzaRepository = new PizzaRepository(); // Создаем экземпляр репозитория
        }

        // Главная страница, передаем данные на представление
        public IActionResult Index()
        {
            var pizzas = _pizzaRepository.GetAllPizzas(); // Получаем пиццы
            return View(pizzas); // Отправляем пиццы в представление
        }

        // Новый метод для получения пицц через API в формате JSON
        public IActionResult GetPizzas()
        {
            var pizzas = _pizzaRepository.GetAllPizzas(); // Получаем пиццы
            return Json(pizzas); // Возвращаем данные в формате JSON
        }

        // Страница Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // Страница ошибки
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}