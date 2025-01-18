using System.Collections.Generic;
using System.Linq; // Подключаем пространство имен для использования First/FirstOrDefault
using PizzaApp.Models;

namespace PizzaApp.PizzaRepositories
{
    public class PizzaRepository
    {
        private readonly List<PizzaModel> _pizzas;

        public PizzaRepository()
        {
            // Инициализируем список пицц
            _pizzas = new List<PizzaModel>
            {
                new PizzaModel(1, "Margherita", 8.99M),
                new PizzaModel(2, "Pepperoni", 10.99M),
                new PizzaModel(3, "Hawaiian", 9.99M),
                new PizzaModel(4, "Veggie", 11.99M)
            };
        }

        // Метод для получения всех пицц
        public IEnumerable<PizzaModel> GetAllPizzas()
        {
            return _pizzas;
        }

        // Метод для получения пиццы по ID
        public PizzaModel FindById(int id)
        {
            // Ищем пиццу по ID, если не найдена, возвращается null (через FirstOrDefault)
            return _pizzas.FirstOrDefault(p => p.Id == id);
        }
    }
}