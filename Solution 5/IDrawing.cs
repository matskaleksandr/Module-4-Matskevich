namespace Solution_5
{
    internal interface IDrawing
    {
        void DrawLine(int x1, int y1, int x2, int y2);//метод для рисования линии
        void DrawCircle(int x, int y, int radius);//метод для рисования окружности
        void DrawRectangle(int x, int y, int width, int height);//метод для рисования прямоугольника
    }
}
