using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PizzaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPizzas()
        {
            var pizzas = new List<object>
            {
                new { Id = 1, Name = "Маргарита", Price = 500 },
                new { Id = 2, Name = "Пепперони", Price = 600 },
                new { Id = 3, Name = "Гавайская", Price = 550 }
            };

            return Ok(pizzas); // Возвращаем список пицц в формате JSON
        }
    }
}