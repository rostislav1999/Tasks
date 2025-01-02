using Microsoft.AspNetCore.Mvc;
using PizzaApp.Repositories;

namespace PizzaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaRepository _pizzaRepository;

        public PizzaController()
        {
            _pizzaRepository = new PizzaRepository(); // Инициализируем репозиторий
        }

        [HttpGet]
        public IActionResult GetPizzas()
        {
            var pizzas = _pizzaRepository.GetAllPizzas();
            return Ok(pizzas);
        }

        [HttpGet("{name}")]
        public IActionResult GetPizzaByName(string name)
        {
            var pizza = _pizzaRepository.GetPizzaByName(name);
            if (pizza == null)
                return NotFound("Pizza not found");
            return Ok(pizza);
        }
    }
}