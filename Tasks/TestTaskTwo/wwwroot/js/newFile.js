$(document).ready(function() {
    // Выполняем запрос к API, чтобы получить список пицц
    $.ajax({
        url: '/api/pizza',
        method: 'GET',
        success: function(data) {
            // Если запрос успешен, выводим пиццы
            var pizzasList = $('#pizzas-list'); // Предполагаем, что у вас есть элемент с id="pizzas-list"
            pizzasList.empty(); // Очищаем предыдущий список
            data.forEach(function(pizza) {
                pizzasList.append(
                    '<li>' + pizza.Name + ' - ' + pizza.Price + ' руб.</li>'
                );
            });
        },
        error: function(error) {
            console.error("Ошибка при получении пицц: ", error);
        }
    });
});
