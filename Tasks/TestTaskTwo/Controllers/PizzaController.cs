using Microsoft.AspNetCore.Mvc;
using PizzaApp.Repositories;

namespace PizzaApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaRepository _pizzaRepository;

        public PizzaController(PizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        // Метод для получения списка пицц в формате JSON
        [HttpGet]
        public IActionResult GetPizzas()
        {
            var pizzas = _pizzaRepository.GetAllPizzas();
            return Ok(pizzas); // Возвращаем список пицц в формате JSON
        }
    }
}