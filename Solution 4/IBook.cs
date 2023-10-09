namespace Solution_4
{
    interface IBook
    {
        string Title { get; }//свойство для получения названия книги (заголовка).
        bool IsAvailable { get; }//свойство для проверки доступности книги.
        void CheckOut();//метод для выдачи книги читателю.
        void Return();//метод для возврата книги в библиотеку после использования.
    }
}
