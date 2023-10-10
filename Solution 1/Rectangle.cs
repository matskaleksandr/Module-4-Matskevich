namespace Solution_1
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }//свойство ширины прямоугольника
        public double Height { get; set; }//свойство высоты прямоугольника

        //конструктор класса Rectangle принимающий ширину и высоту прямоугольника
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        //реализация метода для расчета площади прямоугольника
        public double CalculateArea()
        {
            return Width * Height; //площадь прямоугольника
        }
        //реализация метода для расчета периметра прямоугольника
        public double CalculatePerimeter()
        {
            return 2 * (Width + Height); //вывод периместра прямоугольника
        }
    }
}
