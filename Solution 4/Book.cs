using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    internal class Book : IBook
    {
        
        public string Title { get; }//свойство для получения названия книги (заголовка).
        private bool isAvailable = true;//приватное поле, указывающее доступность книги (по умолчанию доступна).
        public Book(string title)//конструктор класса, принимающий название книги при создании.
        {
            Title = title;
        }
        public bool IsAvailable//реализация свойства для проверки доступности книги.
        {
            get { return isAvailable; }
        }
        //метод для выдачи книги читателю.
        public void CheckOut()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"Книга \"{Title}\" успешно выдана.");
            }
            else
            {
                Console.WriteLine($"Книга \"{Title}\" уже выдана.");
            }
        }
        //метод для возврата книги в библиотеку после использования.
        public void Return()
        {
            if (!isAvailable)
            {
                isAvailable = true;
                Console.WriteLine($"Книга \"{Title}\" успешно возвращена.");
            }
            else
            {
                Console.WriteLine($"Книга \"{Title}\" уже находится в библиотеке.");
            }
        }
    }
}
