using System.Collections.Generic;
using System.Linq; // Для LINQ, если используется FirstOrDefault
using PizzaApp.Models;

namespace PizzaApp.Repositories
{
    public class PizzaRepository
    {
        // Список всех пицц
        private static List<PizzaModel> pizzas = new List<PizzaModel>
        {
new PizzaModel {
    Id = 1,
    Name = "Capriccio",
    Ingredients = "Сыр моцарелла, Соус \"Барбекю\", Соус \"Кальяри\", Пепперонни, Овощи гриль, Бекон, Ветчина, Томаты черри, Шампиньоны",
    Price = 695m,
    Image = "../img/capriccio_2s.jpg"
},
new PizzaModel {
    Id = 2,
    Name = "XXXL",
    Ingredients = "Cыр моцарелла, Соус \"1000\", Куриный рулет, Ветчина, Колбаски охотничьи, Бекон, Сервелат, Огурцы маринованные, Томаты черри, Маслины, Лук маринованный",
    Price = 570m,
    Image = "../img/xxxl_2s.jpg"
},
new PizzaModel {
    Id = 3,
    Name = "4 вкуса",
    Ingredients = "Соус \"1000 островов\", Сыр моцарелла, Рулет куриный, Ветчина, Пепперони, Сыр пармезан, Шампиньоны, Томаты свежие, Маслины/Оливки",
    Price = 495m,
    Image = "../img/4_vkusa_2s.jpg"
},
new PizzaModel {
    Id = 4,
    Name = "Амазонка",
    Ingredients = "Соус \"Томатный\", Сыр моцарелла, Куриная грудка, Брокколи, Огурцы маринованные, Перец болгарский, Шампиньоны, Томаты черри, Маслины, Лук маринованный",
    Price = 515m,
    Image = "../img/amazonka_2s.jpg"
},
new PizzaModel {
    Id = 5,
    Name = "БананZZа",
    Ingredients = "Бананы, Соус \"Гавайский\", Сыр моцарелла, Ананас, Шоколад молочный, Кокос/миндаль, Топпинг клубничный",
    Price = 495m,
    Image = "../img/bananzza_2s.jpg"
},
new PizzaModel {
    Id = 6,
    Name = "Барбекю",
    Ingredients = "Соус \"Томатный\", Сыр моцарелла, Ветчина, Бекон, Пепперони, Соус \"Барбекю\", Томаты, Перец болгарский, Лук маринованный",
    Price = 535m,
    Image = "../img/barbeq_2s.jpg"
},
new PizzaModel {
    Id = 7,
    Name = "Гавайская",
    Ingredients = "Ветчина, Соус \"Гавайский\", Сыр моцарелла, Ананас, Перец болгарский",
    Price = 495m,
    Image = "../img/hawai_2s.jpg"
},
new PizzaModel {
    Id = 8,
    Name = "Гавайская Premium",
    Ingredients = "Соус \"Гавайский\", Сыр моцарелла, Ананас, Ветчина, Куриный рулет, Кукуруза, Перец болгарский",
    Price = 515m,
    Image = "../img/hawai_premium_2s.jpg"
},
new PizzaModel {
    Id = 9,
    Name = "Греческая",
    Ingredients = "Соус \"Кальяри\", Сыр моцарелла, Сливочный сыр, Брокколи, Томаты черри, Перец болгарский, Маслины",
    Price = 525m,
    Image = "../img/grek_2s.jpg"
},
new PizzaModel {
    Id = 10,
    Name = "Грибная",
    Ingredients = "Соус \"Грибной\", Сыр моцарелла, Опята маринованные, Укроп, Шампиньоны, Лук маринованный",
    Price = 495m,
    Image = "../img/gribnaya_2s.jpg"
},
new PizzaModel {
    Id = 11,
    Name = "Деревенская",
    Ingredients = "Соус '1000 островов', Сыр моцарелла, Ветчина, Сервелат, Огурцы маринованные, Опята маринованные, Укроп, Лук маринованный",
    Price = 500m,
    Image = "../img/derevenskaya_2s.jpg"
},
new PizzaModel {
    Id = 12,
    Name = "Домашняя",
    Ingredients = "Соус 'Томатный', Сыр моцарелла, Ветчина, Сервелат, Томаты, Шампиньоны",
    Price = 515m,
    Image = "../img/domashnyaya_2s.jpg"
},
new PizzaModel {
    Id = 13,
    Name = "Дон Бекон",
    Ingredients = "Бекон, Соус 'Кальяри', Сыр моцарелла, Томаты черри",
    Price = 515m,
    Image = "../img/don_bekon_2s.jpg"
},
new PizzaModel {
    Id = 14,
    Name = "Дьябло",
    Ingredients = "Соус 'Томатный', Сыр моцарелла, Ветчина, Пепперони, Соус 'Кимчи', Халапеньо, Томаты",
    Price = 525m,
    Image = "../img/diabolo_2s.jpg"
},
new PizzaModel {
    Id = 15,
    Name = "Кальяри",
    Ingredients = "Соус 'Кальяри', Креветки тигровые, Куриная грудка, Сыр моцарелла, Ананас, Соус 'Унаги', Кунжут",
    Price = 540m,
    Image = "../img/novogodnyaya_2s.jpg"
},
new PizzaModel {
    Id = 16,
    Name = "Колизей",
    Ingredients = "Соус 'Горчичный', Сыр моцарелла, Куринный рулет, Колбаски охотничьи, Соус 'Кисло-сладкий', Томаты свежие, Лук маринованный",
    Price = 525m,
    Image = "../img/kolizey_2s.jpg"
},
new PizzaModel {
    Id = 17,
    Name = "Королевская",
    Ingredients = "Соус 'Кальяри', Сыр моцарелла, Бекон, Креветки тигровые, Сыр пармезан, Томаты черри",
    Price = 610m,
    Image = "../img/korolevskaya_2.jpg"
},
new PizzaModel {
    Id = 18,
    Name = "Крестьянская",
    Ingredients = "Соус '1000 островов', Сыр моцарелла, Бекон, Укроп, Томаты, Шампиньоны, Лук маринованный",
    Price = 500m,
    Image = "../img/krestyanskaya_2s.jpg"
},
new PizzaModel {
    Id = 19,
    Name = "Маргарита",
    Ingredients = "Соус 'Томатный', Сыр моцарелла, Сливочный сыр, Томаты черри",
    Price = 495m,
    Image = "../img/margarita_2s.jpg"
},
new PizzaModel {
    Id = 20,
    Name = "Морская",
    Ingredients = "Соус 'Кальяри', Сыр моцарелла, Кальмар, Креветки тигровые, Мидии, Осьминог, Лимон, Укроп, Лук маринованный, Маслины",
    Price = 570m,
    Image = "../img/morskaya_2s.jpg"
},
new PizzaModel {
    Id = 21,
    Name = "Мясная сборная",
    Ingredients = "Соус 'Барбекю', Сыр моцарелла, Куриный рулет, Ветчина, Бекон, Сервелат, Томаты, Перец болгарский, Лук маринованный, Маслины",
    Price = 540m,
    Image = "../img/myasnaya_sbornaya_2s.jpg"
},
new PizzaModel {
    Id = 22,
    Name = "Остров пепперони",
    Ingredients = "Сыр моцарелла, Соус '1000 островов', Пепперони, Томаты свежие",
    Price = 515m,
    Image = "../img/ostrov_pepperoni_2s.jpg"
},
new PizzaModel {
    Id = 23,
    Name = "Охотничья",
    Ingredients = "Соус '1000 островов', Сыр моцарелла, Сервелат, Бекон, Колбаски охотничьи, Сливочный сыр, Сыр пармезан, Томаты черри, Лук маринованный, Маслины",
    Price = 535m,
    Image = "../img/ohotnichya_2s.jpg"
},
new PizzaModel {
    Id = 24,
    Name = "Пепперони",
    Ingredients = "Соус 'Томатный', Сыр моцарелла, Пепперони",
    Price = 475m,
    Image = "../img/peperoni_2s.jpg"
},
new PizzaModel {
    Id = 25,
    Name = "Пикантная",
    Ingredients = "Соус 'Кальяри', Ветчина, Сливочный сыр, Сыр пармезан, Томаты свежие, Перец болгарский",
    Price = 525m,
    Image = "../img/pikantnaya_2s.jpg"
},
new PizzaModel {
    Id = 26,
    Name = "Поноккио",
    Ingredients = "Соус 'Гавайский', Куриный рулет, Сыр моцарелла, Кукуруза",
    Price = 485m,
    Image = "../img/pinokio_2s.jpg"
},
new PizzaModel {
    Id = 27,
    Name = "Пицца-Cezer",
    Ingredients = "Ветчина, Куриная грудка, Соус 'Кальяри', Сыр моцарелла, Салат айсберг, Сыр пармезан, Соус 'Спайси'",
    Price = 525m,
    Image = "../img/cezar_2s.jpg"
},
new PizzaModel {
    Id = 28,
    Name = "Пицца-бургер",
    Ingredients = "Соус 'Томатный', Сыр моцарелла, Куриный рулет, Ветчина, Соус 'Бургер', Сервелат, Кунжут, Перец болгарский",
    Price = 515m,
    Image = "../img/burger_2s.jpg"
},
new PizzaModel {
    Id = 29,
    Name = "Сардиния",
    Ingredients = "Соус 'Кальяри', Сыр моцарелла, Брокколи, Сливочный сыр, Креветки тигровые, Томаты черри",
    Price = 550m,
    Image = "../img/novogodnyaya_2s.jpg"
},
new PizzaModel {
    Id = 30,
    Name = "Славянская",
    Ingredients = "Соус '1000 островов', Сыр моцарелла, Картофельные дольки, Бекон, Ветчина, Огурцы маринованные, Лук маринованный, Зелень, Томаты свежие",
    Price = 515m,
    Image = "../img/slavyanskaya_2s.jpg"
},
new PizzaModel {
    Id = 31,
    Name = "Сладкая Италия",
    Ingredients = "Соус 'Сливочный', Груша консервированная, Сыр моцарелла, Сыр с голубой плесенью, Орехи грецкие, Мёд натуральный",
    Price = 570m,
    Image = "../img/novogodnyaya_2s.jpg"
},
new PizzaModel {
    Id = 32,
    Name = "Сливочно-острая",
    Ingredients = "Соус '1000 островов', Сыр моцарелла, Сервелат, Бекон, Сливочный сыр, Соус 'Кимчи', Халапеньо, Томаты",
    Price = 515m,
    Image = "../img/slivochno_ostraya_2s.jpg"
},
new PizzaModel {
    Id = 33,
    Name = "Солянка",
    Ingredients = "Соус 'Барбекю', Сыр моцарелла, Колбаски охотничьи, Бекон, Сервелат, Огурцы маринованные, Лимон, Укроп, Томаты черри, Лук маринованный, Маслины",
    Price = 550m,
    Image = "../img/solanka_2s.jpg"
},
new PizzaModel {
    Id = 34,
    Name = "Сырная",
    Ingredients = "Сыр моцарелла, Сливочный сыр, Соус 'Кальяри', Сыр фетаки, Сыр с голубой плесенью, Сыр пармезан",
    Price = 570m,
    Image = "../img/cheese_2s.jpg"
},
new PizzaModel {
    Id = 35,
    Name = "Татарская",
    Ingredients = "Соус 'Томатный', Куриный рулет, Сыр моцарелла, Конно-говяжья колбаса, Лук маринованный, Томаты, Шампиньоны, Перец болгарский",
    Price = 555m,
    Image = "../img/tatarskaya_2s.jpg"
},
new PizzaModel {
    Id = 36,
    Name = "Фиеста",
    Ingredients = "Соус '1000 островов', Сыр моцарелла, Куриный рулет, Колбаски охотничьи, Сливочный сыр, Сервелат, Опята маринованные, Шампиньоны",
    Price = 535m,
    Image = "../img/fiesta_2s.jpg"
},
new PizzaModel {
    Id = 37,
    Name = "Филадельфия",
    Ingredients = "Соус 'Кальяри', Сыр моцарелла, Лосось, Сливочный сыр, Авокадо",
    Price = 600m,
    Image = "../img/filadelf_2s.jpg"
},
new PizzaModel {
    Id = 38,
    Name = "Цезарь с лососем",
    Ingredients = "Сыр моцарелла, Соус 'Кальяри', Свежие томаты, Лосось, Салат айсберг, Соус 'Спайси', Сыр пармезан",
    Price = 600m,
    Image = "../img/cezar_s_lososem_2s.jpg"
}//теперь в бд
        };

        // Метод для получения всех пицц
        public List<PizzaModel> GetAllPizzas()
        {
            return pizzas;
        }

        // Метод для получения пиццы по ID
        public PizzaModel GetPizzaById(int id)
        {
            return pizzas.FirstOrDefault(pizza => pizza.Id == id);
        }

        // Новый метод FindById, который по сути делает то же самое
        public PizzaModel FindById(int id)
        {
            return pizzas.FirstOrDefault(pizza => pizza.Id == id);
        }
    }
}