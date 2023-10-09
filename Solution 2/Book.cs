namespace Solution_2
{
    internal class Book : IProduct
    {
        private string title;//название книги
        private double price;//стоимость книги
        private int stock;//количество книг в наличии на складе

        //конструктор класса Book
        public Book(string title, double price, int stock)
        {
            this.title = title;
            this.price = price;
            this.stock = stock;
        }
        //реализация метода GetCost() из интерфейса IProduct
        public double GetCost()
        {
            return price;// Возвращает стоимость книги
        }
        //реализация метода GetStock() из интерфейса IProduct
        public int GetStock()
        {
            return stock;//возвращает количество книг в наличии на складе
        }
        //переопределение метода ToString() для строкового представления объекта Book
        public override string ToString()
        {
            return $"Товар: {title}, Стоимость: ${price}, Остаток на складе: {stock} шт.";
        }
    }
}
