namespace PizzaApp.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Конструктор с параметрами
        public PizzaModel(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}