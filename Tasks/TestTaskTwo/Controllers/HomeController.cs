using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestTaskTwo.Models;

namespace TestTaskTwo.Controllers
{
    public class PizzaRepository : Controller
    {
        private readonly ILogger<PizzaRepository> _logger;

        public PizzaRepository(ILogger<PizzaRepository> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
