using System;

namespace Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //вывод меню выбора фигуры
                Console.WriteLine("Выберите тип фигуры:");
                Console.WriteLine("1. Круг");
                Console.WriteLine("2. Прямоугольник");
                Console.WriteLine("3. Треугольник");
                Console.WriteLine("4. Выход");
                //считывание выбора пользователя
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Введите радиус круга: ");
                            if (double.TryParse(Console.ReadLine(), out double radius) && radius >= 0)
                            {
                                //создание объекта Circle и вычисление площади и периметра
                                Circle circle = new Circle(radius);
                                Console.WriteLine($"Площадь: {circle.CalculateArea()}");
                                Console.WriteLine($"Периметр: {circle.CalculatePerimeter()}");
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод радиуса. Радиус должен быть неотрицательным числом. Попробуйте снова.");
                            }
                            break;
                        case 2:
                            Console.Write("Введите ширину прямоугольника: ");
                            if (double.TryParse(Console.ReadLine(), out double width) && width >= 0)
                            {
                                Console.Write("Введите высоту прямоугольника: ");
                                if (double.TryParse(Console.ReadLine(), out double height) && height >= 0)
                                {
                                    //создание объекта Rectangle и вычисление площади и периметра
                                    Rectangle rectangle = new Rectangle(width, height);
                                    Console.WriteLine($"Площадь: {rectangle.CalculateArea()}");
                                    Console.WriteLine($"Периметр: {rectangle.CalculatePerimeter()}");
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный ввод высоты. Высота должна быть неотрицательным числом. Попробуйте снова.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод ширины. Ширина должна быть неотрицательным числом. Попробуйте снова.");
                            }
                            break;
                        case 3:
                            Console.Write("Введите длину стороны A треугольника: ");
                            if (double.TryParse(Console.ReadLine(), out double sideA) && sideA >= 0)
                            {
                                Console.Write("Введите длину стороны B треугольника: ");
                                if (double.TryParse(Console.ReadLine(), out double sideB) && sideB >= 0)
                                {
                                    Console.Write("Введите длину стороны C треугольника: ");
                                    if (double.TryParse(Console.ReadLine(), out double sideC) && sideC >= 0)
                                    {
                                        //создание объекта Triangle и вычисление площади и периметра
                                        Triangle triangle = new Triangle(sideA, sideB, sideC);
                                        //проверка можно ли создать такой треугольник
                                        if (!triangle.IsValidTriangle(sideA, sideB, sideC))
                                        {
                                            Console.WriteLine("Невозможно создать треугольник с данными сторонами.");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Площадь: {triangle.CalculateArea()}");
                                            Console.WriteLine($"Периметр: {triangle.CalculatePerimeter()}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Некорректный ввод стороны C. Сторона C должна быть неотрицательным числом. Попробуйте снова.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный ввод стороны B. Сторона B должна быть неотрицательным числом. Попробуйте снова.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод стороны A. Сторона A должна быть неотрицательным числом. Попробуйте снова.");
                            }
                            break;
                        case 4:
                            //выход из программы
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
