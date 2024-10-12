const scrollContainer = document.getElementById('scroll-container');
const scrollSpeed = 1; // Скорость прокрутки

function autoScroll() {
    // Прокручиваем контейнер
    scrollContainer.scrollLeft += scrollSpeed;

    // Пересчитываем ширину, если текущая прокрутка доходит до конца
    const maxScrollLeft = scrollContainer.scrollWidth - scrollContainer.clientWidth;

    // Добавляем буфер (например, 1px) для проверки конца контейнера
    if (scrollContainer.scrollLeft >= maxScrollLeft) {
        scrollContainer.scrollLeft = 0; // Цикличная прокрутка
    }
}

// Запускаем функцию autoScroll каждые 20 миллисекунд
setInterval(autoScroll, 20);

// Обновляем размер при изменении окна
window.addEventListener('resize', () => {
    scrollContainer.scrollLeft = 0; // Сброс на начало при изменении размеров окна
});
