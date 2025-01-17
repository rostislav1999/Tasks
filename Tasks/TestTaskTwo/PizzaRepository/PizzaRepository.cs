using PizzaApp.Models;
using System;
using System.Collections.Generic;

namespace PizzaApp.Repositories
{
    public class PizzaRepository
    {
        // Константный список пицц
        private static readonly List<PizzaModel> pizzas = new List<PizzaModel>()
        {
new PizzaModel(
    name: "Нового222222222дняя",
    image: "../img/novogodnyaya_2s.jpg",
    composition: new List<string>{ "Соус \"Гавайский\"", "Сыр моцарелла", "Куриная грудка", "Мандарины консервированные", "Стружка миндаля", "Кокосовая стружка" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное Толстое",
    price: 550m,
    weight: "670g"
),
new PizzaModel(
    name: "Capriccio",
    image: "../img/capriccio_2s.jpg",
    composition: new List<string>{ "Сыр моцарелла", "Соус \"Барбекю\"", "Соус \"Кальяри\"", "Пепперонни", "Овощи гриль", "Бекон", "Ветчина", "Томаты черри", "Шампиньоны" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное Толстое",
    price: 695m,
    weight: "980g"
),
new PizzaModel(
    name: "XXXL",
    image: "../img/xxxl_2s.jpg",
    composition: new List<string>{ "Cыр моцарелла", "Соус \"1000\"", "Куриный рулет", "Ветчина", "Колбаски охотничьи", "Бекон", "Сервелат", "Огурцы маринованные", "Томаты черри", "Маслины", "Лук маринованный" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное Толстое",
    price: 570m,
    weight: "740g"
),
new PizzaModel(
    name: "4 вкуса",
    image: "../img/4_vkusa_2s.jpg",
    composition: new List<string>{ "Соус \"1000 островов\"", "Сыр моцарелла", "Рулет куриный", "Ветчина", "Пепперони", "Сыр пармезан", "Шампиньоны", "Томаты свежие", "Маслины/Оливки" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное Толстое",
    price: 495m,
    weight: "540g"
),
new PizzaModel(
    name: "Амазонка",
    image: "../img/amazonka_2s.jpg",
    composition: new List<string>{ "Соус \"Томатный\"", "Сыр моцарелла", "Куриная грудка", "Брокколи", "Огурцы маринованные", "Перец болгарский", "Шампиньоны", "Томаты черри", "Маслины", "Лук маринованный" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное Толстое",
    price: 515m,
    weight: "600g"
),
new PizzaModel(
    name: "БананZZа",
    image: "../img/bananzza_2s.jpg",
    composition: new List<string>{ "Бананы", "Соус \"Гавайский\"", "Сыр моцарелла", "Ананас", "Шоколад молочный", "Кокос/миндаль", "Топпинг клубничный" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное Толстое",
    price: 495m,
    weight: "520g"
),
new PizzaModel(
    name: "Барбекю",
    image: "../img/barbeq_2s.jpg",
    composition: new List<string>{ "Соус \"Томатный\"", "Сыр моцарелла", "Ветчина", "Бекон", "Пепперони", "Соус \"Барбекю\"", "Томаты", "Перец болгарский", "Лук маринованный" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное Толстое",
    price: 535m,
    weight: "590g"
),
new PizzaModel(
    name: "Гавайская",
    image: "../img/hawai_2s.jpg",
    composition: new List<string>{ "Ветчина", "Соус \"Гавайский\"", "Сыр моцарелла", "Ананас", "Перец болгарский" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное Толстое",
    price: 495m,
    weight: "550g"
),
new PizzaModel(
    name: "Гавайская Premium",
    image: "../img/hawai_premium_2s.jpg",
    composition: new List<string>{ "Соус \"Гавайский\"", "Сыр моцарелла", "Ананас", "Ветчина", "Куриный рулет", "Кукуруза", "Перец болгарский" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное Толстое",
    price: 515m,
    weight: "590g"
),
new PizzaModel(
    name: "Греческая",
    image: "../img/grek_2s.jpg",
    composition: new List<string>{ "Соус \"Кальяри\"", "Сыр моцарелла", "Сливочный сыр", "Брокколи", "Томаты черри", "Перец болгарский", "Маслины" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное Толстое",
    price: 525m,
    weight: "570g"
    ),
new PizzaModel(
    name: "Грибная",
    image: "../img/gribnaya_2s.jpg",
    composition: new List<string>{ "Соус \"Грибной\"", "Сыр моцарелла", "Опята маринованные", "Укроп", "Шампиньоны", "Лук маринованный" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное Толстое",
    price: 495m,
    weight: "550g"
),
new PizzaModel(
    name: "Деревенская",
    image: "../img/derevenskaya_2s.jpg",
    composition: new List<string>{ "Соус '1000 островов'", "Сыр моцарелла", "Ветчина", "Сервелат", "Огурцы маринованные", "Опята маринованные", "Укроп", "Лук маринованный" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 500m,
    weight: "560 г"
),
new PizzaModel(
    name: "Домашняя",
    image: "../img/domashnyaya_2s.jpg",
    composition: new List<string>{ "Соус 'Томатный'", "Сыр моцарелла", "Ветчина", "Сервелат", "Томаты", "Шампиньоны" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 515m,
    weight: "510 г"
),
new PizzaModel(
    name: "Дон Бекон",
    image: "../img/don_bekon_2s.jpg",
    composition: new List<string>{ "Бекон", "Соус 'Кальяри'", "Сыр моцарелла", "Томаты черри" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 515m,
    weight: "550 г"
),
new PizzaModel(
    name: "Дьябло",
    image: "../img/diabolo_2s.jpg",
    composition: new List<string>{ "Соус 'Томатный'", "Сыр моцарелла", "Ветчина", "Пепперони", "Соус 'Кимчи'", "Халапеньо", "Томаты" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 525m,
    weight: "560 г"
),
new PizzaModel(
    name: "Кальяри",
    image: "../img/novogodnyaya_2s.jpg",
    composition: new List<string>{ "Соус 'Кальяри'", "Креветки тигровые", "Куриная грудка", "Сыр моцарелла", "Ананас", "Соус 'Унаги'", "Кунжут" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 540m,
    weight: "560 г"
),
new PizzaModel(
    name: "Колизей",
    image: "../img/kolizey_2s.jpg",
    composition: new List<string>{ "Соус 'Горчичный'", "Сыр моцарелла", "Куринный рулет", "Колбаски охотничьи", "Соус 'Кисло-сладкий'", "Томаты свежие", "Лук маринованный" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 525m,
    weight: "660 г"
),
new PizzaModel(
    name: "Королевская",
    image: "../img/korolevskaya_2.jpg",
    composition: new List<string>{ "Соус 'Кальяри'", "Сыр моцарелла", "Бекон", "Креветки тигровые", "Сыр пармезан", "Томаты черри" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 610m,
    weight: "580 г"
),
new PizzaModel(
    name: "Крестьянская",
    image: "../img/krestyanskaya_2s.jpg",
    composition: new List<string>{ "Соус '1000 островов'", "Сыр моцарелла", "Бекон", "Укроп", "Томаты", "Шампиньоны", "Лук маринованный" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 500m,
    weight: "585 г"
),
new PizzaModel(
    name: "Маргарита",
    image: "../img/margarita_2s.jpg",
    composition: new List<string>{ "Соус 'Томатный'", "Сыр моцарелла", "Сливочный сыр", "Томаты черри" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 495m,
    weight: "460 г"
),
new PizzaModel(
    name: "Морская",
    image: "../img/morskaya_2s.jpg",
    composition: new List<string>{ "Соус 'Кальяри'", "Сыр моцарелла", "Кальмар", "Креветки тигровые", "Мидии", "Осьминог", "Лимон", "Укроп", "Лук маринованный", "Маслины" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 570m,
    weight: "550 г"
),
new PizzaModel(
    name: "Мясная сборная",
    image: "../img/myasnaya_sbornaya_2s.jpg",
    composition: new List<string>{ "Соус 'Барбекю'", "Сыр моцарелла", "Куриный рулет", "Ветчина", "Бекон", "Сервелат", "Томаты", "Перец болгарский", "Лук маринованный", "Маслины" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 540m,
    weight: "510 г"
),
new PizzaModel(
    name: "Остров пепперони",
    image: "../img/ostrov_pepperoni_2s.jpg",
    composition: new List<string>{ "Сыр моцарелла", "Соус '1000 островов'", "Пепперони", "Томаты свежие" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 515m,
    weight: "нет данных"
),
new PizzaModel(
    name: "Охотничья",
    image: "../img/ohotnichya_2s.jpg",
    composition: new List<string>{ "Соус '1000 островов'", "Сыр моцарелла", "Сервелат", "Бекон", "Колбаски охотничьи", "Сливочный сыр", "Сыр пармезан", "Томаты черри", "Лук маринованный", "Маслины" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 535m,
    weight: "560 г"
),
new PizzaModel(
    name: "Пепперони",
    image: "../img/peperoni_2s.jpg",
    composition: new List<string>{ "Соус 'Томатный'", "Сыр моцарелла", "Пепперони" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 475m,
    weight: "410 г"
),
new PizzaModel(
    name: "Пикантная",
    image: "../img/pikantnaya_2s.jpg",
    composition: new List<string>{ "Соус 'Кальяри'", "Ветчина", "Сливочный сыр", "Сыр пармезан", "Томаты свежие", "Перец болгарский" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 525m,
    weight: "510 г"
),
new PizzaModel(
    name: "Поноккио",
    image: "../img/pinokio_2s.jpg",
    composition: new List<string>{ "Соус 'Гавайский'", "Куриный рулет", "Сыр моцарелла", "Кукуруза" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 485m,
    weight: "510 г"
),
new PizzaModel(
    name: "Пицца-Cezer",
    image: "../img/cezar_2s.jpg",
    composition: new List<string>{ "Ветчина", "Куриная грудка", "Соус 'Кальяри'", "Сыр моцарелла", "Салат айсберг", "Сыр пармезан", "Соус 'Спайси'" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 525m,
    weight: "640 г"
),
new PizzaModel(
    name: "Пицца-бургер",
    image: "../img/burger_2s.jpg",
    composition: new List<string>{ "Соус 'Томатный'", "Сыр моцарелла", "Куриный рулет", "Ветчина", "Соус 'Бургер'", "Сервелат", "Кунжут", "Перец болгарский" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 515m,
    weight: "570 г"
),
new PizzaModel(
    name: "Сардиния",
    image: "../img/novogodnyaya_2s.jpg",
    composition: new List<string>{ "Соус 'Кальяри'", "Сыр моцарелла", "Брокколи", "Сливочный сыр", "Креветки тигровые", "Томаты черри" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 550m,
    weight: "520 г"
),
new PizzaModel(
    name: "Славянская",
    image: "../img/slavyanskaya_2s.jpg",
    composition: new List<string>{ "Соус '1000 островов'", "Сыр моцарелла", "Картофельные дольки", "Бекон", "Ветчина", "Огурцы маринованные", "Лук маринованный", "Зелень", "Томаты свежие" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 515m,
    weight: "560 г"
),
new PizzaModel(
    name: "Сладкая Италия",
    image: "../img/novogodnyaya_2s.jpg",
    composition: new List<string>{ "Соус 'Сливочный'", "Груша консервированная", "Сыр моцарелла", "Сыр с голубой плесенью", "Орехи грецкие", "Мёд натуральный" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 570m,
    weight: "530 г"
),
new PizzaModel(
    name: "Сливочно-острая",
    image: "../img/slivochno_ostraya_2s.jpg",
    composition: new List<string>{ "Соус '1000 островов'", "Сыр моцарелла", "Сервелат", "Бекон", "Сливочный сыр", "Соус 'Кимчи'", "Халапеньо", "Томаты" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 515m,
    weight: "580 г"
),
new PizzaModel(
    name: "Солянка",
    image: "../img/solanka_2s.jpg",
    composition: new List<string>{ "Соус 'Барбекю'", "Сыр моцарелла", "Колбаски охотничьи", "Бекон", "Сервелат", "Огурцы маринованные", "Лимон", "Укроп", "Томаты черри", "Лук маринованный", "Маслины" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 550m,
    weight: "600 г"
),
new PizzaModel(
    name: "Сырная",
    image: "../img/cheese_2s.jpg",
    composition: new List<string>{ "Сыр моцарелла", "Сливочный сыр", "Соус 'Кальяри'", "Сыр фетаки", "Сыр с голубой плесенью", "Сыр пармезан" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 570m,
    weight: "550 г"
),
new PizzaModel(
    name: "Татарская",
    image: "../img/tatarskaya_2s.jpg",
    composition: new List<string>{ "Соус 'Томатный'", "Куриный рулет", "Сыр моцарелла", "Конно-говяжья колбаса", "Лук маринованный", "Томаты", "Шампиньоны", "Перец болгарский" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 555m,
    weight: "580 г"
),
new PizzaModel(
    name: "Фиеста",
    image: "../img/fiesta_2s.jpg",
    composition: new List<string>{ "Соус '1000 островов'", "Сыр моцарелла", "Куриный рулет", "Колбаски охотничьи", "Сливочный сыр", "Сервелат", "Опята маринованные", "Шампиньоны" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 535m,
    weight: "580 г"
),
new PizzaModel(
    name: "Филадельфия",
    image: "../img/filadelf_2s.jpg",
    composition: new List<string>{ "Соус 'Кальяри'", "Сыр моцарелла", "Лосось", "Сливочный сыр", "Авокадо" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 600m,
    weight: "510 г"
),
new PizzaModel(
    name: "Цезарь с лососем",
    image: "../img/cezar_s_lososem_2s.jpg",
    composition: new List<string>{ "Сыр моцарелла", "Соус 'Кальяри'", "Свежие томаты", "Лосось", "Салат айсберг", "Соус 'Спайси'", "Сыр пармезан" },
    sizes: new List<string>{ "30 см", "40 см", "60 см" },
    crust: "Традиционное толстое",
    price: 600m,
    weight: "550 г"
)
        };

        // Метод для получения списка всех пицц
        public List<PizzaModel> GetAllPizzas()
        {
            // Возвращаем список пицц, если он не пустой, иначе возвращаем пустой список
            return pizzas ?? new List<PizzaModel>();
        }


        // Метод для получения списка всех пицц (возвращение константного поля)
        public List<PizzaModel> GetAllPizzasStatic()
        {
            // Возвращаем список пицц, если он не пустой, иначе возвращаем пустой список
            return pizzas ?? new List<PizzaModel>();
        }
    }
}