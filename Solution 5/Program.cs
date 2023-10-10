using System;

namespace Solution_5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1.Нарисовать линию");
            Console.WriteLine("2.Нарисовать окружность");
            Console.WriteLine("3.Нарисовать прямоугольник");
            Console.WriteLine("4.Очистить холст");
            Console.WriteLine("5.Выйти");

            Canvas canvas = new Canvas(20, 20);

            bool running = true;
            while (running)
            {
                Console.Write("Введите команду (1-5): ");
                int command;
                if (int.TryParse(Console.ReadLine(), out command))
                {
                    switch (command)
                    {
                        case 1:
                            Console.Write("Введите x1: ");
                            int x1 = int.Parse(Console.ReadLine());
                            Console.Write("Введите y1: ");
                            int y1 = int.Parse(Console.ReadLine());
                            Console.Write("Введите x2: ");
                            int x2 = int.Parse(Console.ReadLine());
                            Console.Write("Введите y2: ");
                            int y2 = int.Parse(Console.ReadLine());
                            canvas.DrawLine(x1, y1, x2, y2);
                            break;
                        case 2:
                            Console.Write("Введите центр x: ");
                            int centerX = int.Parse(Console.ReadLine());
                            Console.Write("Введите центр y: ");
                            int centerY = int.Parse(Console.ReadLine());
                            Console.Write("Введите радиус: ");
                            int radius = int.Parse(Console.ReadLine());
                            canvas.DrawCircle(centerX, centerY, radius);
                            break;
                        case 3:
                            Console.Write("Введите верхний левый угол x: ");
                            int rectX = int.Parse(Console.ReadLine());
                            Console.Write("Введите верхний левый угол y: ");
                            int rectY = int.Parse(Console.ReadLine());
                            Console.Write("Введите ширину: ");
                            int rectWidth = int.Parse(Console.ReadLine());
                            Console.Write("Введите высоту: ");
                            int rectHeight = int.Parse(Console.ReadLine());
                            canvas.DrawRectangle(rectX, rectY, rectWidth, rectHeight);
                            break;
                        case 4:
                            canvas.ClearCanvas();
                            break;
                        case 5:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Неверная команда. Пожалуйста, введите корректную команду (1-5).");
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine("1. Нарисовать линию");
                    Console.WriteLine("2. Нарисовать окружность");
                    Console.WriteLine("3. Нарисовать прямоугольник");
                    Console.WriteLine("4. Очистить холст");
                    Console.WriteLine("5. Выйти");
                    canvas.DisplayCanvas();
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите корректную команду (1-5).");
                }
            }
        }
    }
}
