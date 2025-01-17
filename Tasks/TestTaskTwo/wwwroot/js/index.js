const express = require('express');
const app = express();
const port = 7052;

// Для обслуживания статических файлов (например, картинки и CSS)
app.use(express.static('public'));


app.get('/getPizzas', function (req, res) {
    const pizzas = [
        {
            name: "Новогодняя",
            image: "img/novogodnyaya_2s.jpg",
            composition: [
                "Соус 'Гавайский'",
                "Сыр моцарелла",
                "Куриная грудка",
                "Мандарины консервированные",
                "Стружка миндаля",
                "Кокосовая стружка"
            ],
            sizes: ["30 см", "40 см", "60 см"],
            crust: "Традиционное Толстое",
            price: 550,
            weight: "670 гр"
        },
        {
            name: "Цезарь с лососем",
            image: "img/cezar_s_lososyem.jpg",
            composition: [
                "Сыр моцарелла",
                "Соус 'Кальяри'",
                "Свежие томаты",
                "Лосось",
                "Салат айсберг",
                "Соус 'Спайси'",
                "Сыр пармезан"
            ],
            sizes: ["30 см", "40 см", "60 см"],
            crust: "Традиционное Толстое",
            price: 600,
            weight: "550 гр"
        }
    ];


    res.json(pizzas);
});

app.listen(port, () => {
    console.log(`Сервер работает на http://localhost:${port}`);
});