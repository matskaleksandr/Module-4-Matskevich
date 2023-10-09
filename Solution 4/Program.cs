using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<IBook> library = new List<IBook>();//создаем список книг, представленных интерфейсом IBook.
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Проверить доступность книги");
                Console.WriteLine("2. Выдать книгу");
                Console.WriteLine("3. Вернуть книгу");
                Console.WriteLine("4. Добавить книгу");
                Console.WriteLine("5. Выйти");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 5)
                    {
                        //выход из программы при выборе "5".
                        Environment.Exit(0);
                    }
                    else if (choice >= 1 && choice <= 4)
                    {
                        if (choice == 4)
                        {
                            Console.Write("Введите название книги: ");
                            string bookTitle = Console.ReadLine();
                            //добавление новой книги в библиотеку.
                            library.Add(new Book(bookTitle));
                            Console.WriteLine($"Книга \"{bookTitle}\" успешно добавлена в библиотеку.");
                        }
                        else
                        {
                            Console.Write("Введите название книги: ");
                            string bookTitle = Console.ReadLine();
                            //поиск книги по названию в библиотеке.
                            IBook book = library.Find(b => b.Title == bookTitle);
                            if (book != null)
                            {
                                if (choice == 1)//проверка доступности книги и вывод результата.
                                {
                                    bool available = book.IsAvailable;
                                    Console.WriteLine($"Книга \"{bookTitle}\" доступна: {available}");
                                }
                                else if (choice == 2)
                                {                                    
                                    book.CheckOut();//выдача книги читателю.
                                }
                                else if (choice == 3)
                                {                                    
                                    book.Return();//возврат книги в библиотеку.
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Книга \"{bookTitle}\" не найдена в библиотеке.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                }
            }
        }
    }
}
