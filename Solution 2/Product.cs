namespace Solution_2
{
    internal class Product : IProduct
    {
        private string title;//название
        private double price;//стоимость
        private int stock;//количество в наличии на складе

        public Product(string title, double price, int stock)
        {
            this.title = title;
            this.price = price;
            this.stock = stock;
        }
        //реализация метода из интерфейса IProduct
        public double GetCost()
        {
            return price;// Возвращает стоимость книги
        }
        //реализация метода из интерфейса IProduct
        public int GetStock()
        {
            return stock;//возвращает количество товара на складе
        }
        public override string ToString()
        {
            return $"Товар: {title}, Стоимость: ${price}, Остаток на складе: {stock} шт.";
        }
    }
}
