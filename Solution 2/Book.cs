namespace Solution_2
{
    internal class Book : IProduct
    {
        private string title;   // Название книги
        private double price;   // Стоимость книги
        private int stock;      // Количество книг в наличии на складе

        // Конструктор класса Book, принимающий название, стоимость и количество книг в наличии
        public Book(string title, double price, int stock)
        {
            this.title = title;
            this.price = price;
            this.stock = stock;
        }

        // Реализация метода GetCost() из интерфейса IProduct
        public double GetCost()
        {
            return price;  // Возвращает стоимость книги
        }

        // Реализация метода GetStock() из интерфейса IProduct
        public int GetStock()
        {
            return stock;  // Возвращает количество книг в наличии на складе
        }

        // Переопределение метода ToString() для строкового представления объекта Book
        public override string ToString()
        {
            return $"Товар: {title}, Стоимость: ${price}, Остаток на складе: {stock} шт.";
        }
    }
}
