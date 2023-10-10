using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_5
{
    public class Canvas : IDrawing
    {
        private char[,] canvas; // Холст в виде двумерного массива символов
        private int width;      // Ширина холста
        private int height;     // Высота холста

        // Конструктор класса Canvas (Холст) для инициализации холста заданного размера
        public Canvas(int width, int height)
        {
            this.width = width;
            this.height = height;
            canvas = new char[width, height];
            ClearCanvas(); // Очищаем холст при создании экземпляра
        }

        // Метод для очистки холста, заполняя его пробелами
        public void ClearCanvas()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    canvas[x, y] = ' ';
                }
            }
        }

        // Метод для вывода содержимого холста на консоль
        public void DisplayCanvas()
        {
            Console.WriteLine("Холст:");
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(canvas[x, y]);
                }
                Console.WriteLine();
            }
        }

        // Метод для рисования линии на холсте
        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            // Алгоритм Bresenham для рисования линии
            int deltaX = Math.Abs(x2 - x1);
            int deltaY = Math.Abs(y2 - y1);
            int generatedPixels = 1 + ((deltaX > deltaY) ? deltaX : deltaY);
            int currentX = x1;
            int currentY = y1;

            int stepX, stepY;

            if (x1 < x2)
            {
                stepX = 1;
            }
            else
            {
                stepX = -1;
            }

            if (y1 < y2)
            {
                stepY = 1;
            }
            else
            {
                stepY = -1;
            }

            if (deltaX > deltaY)
            {
                int accumulatedError = generatedPixels / 2;
                for (int i = 0; i < generatedPixels; i++)
                {
                    canvas[currentX, currentY] = '*';
                    accumulatedError += deltaY;
                    if (accumulatedError >= deltaX)
                    {
                        accumulatedError -= deltaX;
                        currentY += stepY;
                    }
                    currentX += stepX;
                }
            }
            else
            {
                int accumulatedError = generatedPixels / 2;
                for (int i = 0; i < generatedPixels; i++)
                {
                    canvas[currentX, currentY] = '*';
                    accumulatedError += deltaX;
                    if (accumulatedError >= deltaY)
                    {
                        accumulatedError -= deltaY;
                        currentX += stepX;
                    }
                    currentY += stepY;
                }
            }
        }

        // Метод для рисования окружности на холсте
        public void DrawCircle(int x, int y, int radius)
        {
            // Алгоритм для рисования окружности
            for (int angle = 0; angle < 360; angle++)
            {
                double radians = angle * (Math.PI / 180);
                int circleX = (int)(x + radius * Math.Cos(radians));
                int circleY = (int)(y + radius * Math.Sin(radians));

                if (circleX >= 0 && circleX < width && circleY >= 0 && circleY < height)
                {
                    canvas[circleX, circleY] = '*';
                }
            }
        }

        // Метод для рисования прямоугольника на холсте
        public void DrawRectangle(int x, int y, int width, int height)
        {
            // Рисование прямоугольника
            for (int i = x; i < x + width; i++)
            {
                for (int j = y; j < y + height; j++)
                {
                    if (i >= 0 && i < this.width && j >= 0 && j < this.height)
                    {
                        canvas[i, j] = '*';
                    }
                }
            }
        }
    }
}
