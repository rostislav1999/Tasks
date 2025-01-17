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
    }
}