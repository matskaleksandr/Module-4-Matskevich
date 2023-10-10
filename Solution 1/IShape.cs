using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    public interface IShape
    {
        //метод для расчета площади фигуры
        double CalculateArea();
        //метод для расчета периметра фигуры
        double CalculatePerimeter();
    }
}
