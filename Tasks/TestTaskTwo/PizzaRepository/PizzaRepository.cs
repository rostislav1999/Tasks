using System.Collections.Generic;
using System.Linq; // Подключаем пространство имен для использования First/FirstOrDefault
using PizzaApp.Models;

namespace PizzaApp.PizzaRepositories
{
    public class PizzaRepository
    {
        public IEnumerable<PizzaModel> GetAllPizzas()
        {
            return new List<PizzaModel>
            {
                new PizzaModel(1, "4 вкуса", 8.99M, "~/img/4_vkusa_2s.jpg"),
                new PizzaModel(2, "Амазонка", 10.99M, "~/img/amazonka_2s.jpg"),
                new PizzaModel(3, "БананнZZa", 9.99M, "~/img/bananzza_2s.jpg"),
                new PizzaModel(4, "Барбекью", 11.99M, "~/img/barbeq_2s.jpg")
                  };
        }

        public PizzaModel FindById(int id)
        {
            return GetAllPizzas().FirstOrDefault(p => p.Id == id);
        }
    }
}
