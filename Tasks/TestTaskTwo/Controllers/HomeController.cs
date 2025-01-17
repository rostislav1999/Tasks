using Microsoft.AspNetCore.Mvc;
using PizzaApp.PizzaRepositories;
using TestTaskTwo.Models;
using System.Collections.Generic;
using System.Diagnostics;
using PizzaApp;

namespace TestTaskTwo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PizzaRepository _pizzaRepository;

        // Конструктор контроллера
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _pizzaRepository = new PizzaRepository();
        }

        // Метод для отображения главной страницы с пиццами
        public IActionResult Index()
        {
            var pizzas = _pizzaRepository.GetAllPizzas(); // Исправлено название метода
            return View(pizzas);
        }

        // Метод для получения списка пицц в формате JSON
        public IActionResult GetPizzas()
        {
            var pizzas = _pizzaRepository.GetAllPizzas(); // Исправлено название метода
            return Json(pizzas);
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