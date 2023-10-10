using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    using System;

    public class Triangle : IShape
    {
        public double SideA { get; set; }//1 сторона
        public double SideB { get; set; }//2 сторона
        public double SideC { get; set; }//3 сторона
                                         //конструктор класса
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        //метод для проверки являются ли заданные стороны допустимыми для создания треугольника
        public bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
        //реализация метода для расчета площади треугольника
        public double CalculateArea()
        {
            //используется формула Герона для расчета площади треугольника
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
        //реализация метода для расчета периметра треугольника
        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }

}
