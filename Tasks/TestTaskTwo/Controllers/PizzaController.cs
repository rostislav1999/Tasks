using Microsoft.AspNetCore.Mvc;
using PizzaApp.Repositories;
using PizzaApp.Models;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzaRepository _pizzaRepository;

        public PizzaController()
        {
            _pizzaRepository = new PizzaRepository();
        }

        public IActionResult Index()
        {
            var pizzas = _pizzaRepository.GetAllPizzas(); 
            return View(pizzas); 
        }
    }
}