using System;
using System.Collections.Generic;
using PizzaApp.Models; // Подключаем пространство имен с моделью пиццы

namespace PizzaApp.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }

        public string Image { get; set; }

        public PizzaModel(int id, string name, string ingredients,  string image,  decimal price)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
            Image = image;
            Price = price;
        }

        public PizzaModel()
        {
        }
    }
}