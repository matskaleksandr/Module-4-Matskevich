using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    public class Circle : IShape
    {
        public double Radius { get; set; }//свойства
        //конструктор класса
        public Circle(double radius)
        {
            Radius = radius;
        }
        //реализация метода для расчета площади круга
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;//возвращение и расчёт площади круга
        }
        //реализация метода для расчета длины окружности круга
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius; //возвращение и расчёт окружности круга
        }
    }
}
