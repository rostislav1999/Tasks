using System;
using System.Collections.Generic;
using PizzaApp.Models; // Подключаем пространство имен с моделью пиццы

namespace PizzaApp.Repositories
{
    public class PizzaRepository
    {
        // Константный список пицц
        private static readonly List<PizzaModel> pizzas = new List<PizzaModel>()
        {
            new PizzaModel(
                name: "Маргарита",
                image: "images/margherita.jpg",
                composition: new List<string>{ "Томатный соус", "Моцарелла", "Базилик" },
                sizes: new List<string>{ "Маленькая", "Средняя", "Большая" },
                crust: "Тонкое тесто",
                price: 350m,
                weight: "450g"
            ),
            new PizzaModel(
                name: "Пепперони",
                image: "images/pepperoni.jpg",
                composition: new List<string>{ "Томатный соус", "Моцарелла", "Пепперони" },
                sizes: new List<string>{ "Средняя", "Большая" },
                crust: "Толстое тесто",
                price: 400m,
                weight: "500g"
            ),
            new PizzaModel(
                name: "Гавайская",
                image: "images/hawaiian.jpg",
                composition: new List<string>{ "Томатный соус", "Моцарелла", "Гавайский микс" },
                sizes: new List<string>{ "Маленькая", "Средняя" },
                crust: "Тонкое тесто",
                price: 420m,
                weight: "460g"
            )
        };

        // Метод для получения списка всех пицц
        public List<PizzaModel> GetAllPizzas()
        {
            return pizzas;
        }

        // Метод для поиска пиццы по названию
        public PizzaModel GetPizzaByName(string name)
        {
            return pizzas.Find(pizza => pizza.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}