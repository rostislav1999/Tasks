using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace TestTaskTwo.Models
{
    class PizzaModel
    {
        ActivatorUtilitiesConstructorAttribute(name, image, composition, sizes, crust, price, weight)
        {
            this.name = name;               // Название пиццы
            this.image = image;             // Путь к изображению
            this.composition = composition; // Состав пиццы
            this.sizes = sizes;             // Размеры пиццы
            this.crust = crust;             // Тип теста
            this.price = price;             // Цена
            this.weight = weight;           // Вес
        }

        // Метод для вывода информации о пицце
        getPizzaInfo()
        {
            return
            Название: ${ this.name}
        Состав: ${ this.composition.join(", ")}
        Размеры: ${ this.sizes.join(", ")}
        Тесто: ${ this.crust}
        Цена: ${ this.price}
            руб.
        Вес: ${ this.weight};
        }
}

// Пример создания экземпляров PizzaModel на основе массива pizzas
const pizzasModels = pizzas.map(pizza =>
    new PizzaModel(
        pizza.name,
        pizza.image,
        pizza.composition,
        pizza.sizes,
        pizza.crust,
        pizza.price,
        pizza.weight
    )
);

// Пример использования
console.log(pizzasModels[0].getPizzaInfo());
}
