using System;
using System.Collections.Generic;
namespace PizzaApp.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; } 

        public PizzaModel(int id, string name, decimal price, string image)
        {
            Id = id;
            Name = name;
            Price = price;
            Image = image;
        }
    }
}