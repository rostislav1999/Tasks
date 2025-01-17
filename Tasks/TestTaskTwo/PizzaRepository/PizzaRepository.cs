using System.Collections.Generic;
using PizzaApp.Models;

namespace PizzaApp.PizzaRepositories
{
    public class PizzaRepository
    {
        public IEnumerable<PizzaModel> GetAllPizzas()
        {
            return new List<PizzaModel>
            {
                new PizzaModel(1, "Margherita", 8.99M),
                new PizzaModel(2, "Pepperoni", 10.99M),
                new PizzaModel(3, "Hawaiian", 9.99M),
                new PizzaModel(4, "Veggie", 11.99M)
            };
        }
    }
}