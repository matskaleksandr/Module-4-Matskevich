using System;

namespace Solution_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта StoreManager для управления списком товаров
            StoreManager storeManager = new StoreManager();

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить товар");
                Console.WriteLine("2. Просмотреть список товаров");
                Console.WriteLine("3. Выход");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Введите название товара: ");
                            string title = Console.ReadLine();
                            Console.Write("Введите стоимость товара: ");
                            if (double.TryParse(Console.ReadLine(), out double price))
                            {
                                Console.Write("Введите остаток товара на складе: ");
                                if (int.TryParse(Console.ReadLine(), out int stock))
                                {
                                    // Создание нового товара (Book) и добавление его в хранилище
                                    IProduct newProduct = new Book(title, price, stock);
                                    storeManager.AddProduct(newProduct);
                                    Console.WriteLine("Товар добавлен.");
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный ввод остатка. Попробуйте снова.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод стоимости. Попробуйте снова.");
                            }
                            break;
                        case 2:
                            // Вывод списка товаров из хранилища
                            storeManager.DisplayProducts();
                            break;
                        case 3:
                            // Выход из программы
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
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
