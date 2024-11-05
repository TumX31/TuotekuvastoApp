// Ждем, пока весь HTML-документ будет загружен и готов к взаимодействию
document.addEventListener('DOMContentLoaded', function () {

    // Находим все заголовки h2 внутри карточек продукта и проходим по каждому элементу
    document.querySelectorAll('.product-card h2').forEach(function (element) {
        // Заменяем текст заголовка, чтобы каждое слово начиналось с заглавной буквы
        element.textContent = element.textContent.replace(/\b\w/g, function (char) {
            return char.toUpperCase(); // Преобразуем первую букву каждого слова в заглавную
        });
    });

    // Находим четвертый параграф внутри каждой карточки продукта (предполагается, что это цена)
    document.querySelectorAll('.product-card p:nth-child(4)').forEach(function (element) {
        // Извлекаем текст и убираем лишние символы для конвертации в число
        let price = parseFloat(element.textContent.replace('Price: ', '').replace(' €', ''));

        // Форматируем цену: задаем два десятичных знака и заменяем точку на запятую
        element.textContent = `Price: ${price.toFixed(2).replace('.', ',')} €`;
    });
});
