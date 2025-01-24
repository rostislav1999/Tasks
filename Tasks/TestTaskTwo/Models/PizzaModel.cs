using System;
using System.Collections.Generic;
using PizzaApp.Models; // Подключаем пространство имен с моделью пиццы

namespace PizzaApp.Models
{
    public class PizzaModel
    {
        public int Id { get; set; } 
       
        public string Ingredients { get; set; }
       
        public string Name { get; set; }
        public string Image { get; set; }
        public List<string> Composition { get; set; }
        public List<string> Sizes { get; set; }
        public string Crust { get; set; }
        public decimal Price { get; set; }
        public string Weight { get; set; }

        public PizzaModel(int id, string ingredients, string name, string image, List<string> composition, List<string> sizes, string crust, decimal price, string weight)
        {
            Id = id;
            Ingredients = ingredients;
            Name = name;
            Image = image;
            Composition = composition;
            Sizes = sizes;
            Crust = crust;
            Price = price;
            Weight = weight;
        }
    }
}