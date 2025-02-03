using System;
using System.Collections.Generic;

namespace PizzaApp.Models
{
    public partial class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}