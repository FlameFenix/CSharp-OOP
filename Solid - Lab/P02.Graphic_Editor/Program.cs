using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            GraphicEditor circle = new Circle();

            circle.DrawShape();

            GraphicEditor star = new Star();
            star.DrawShape();
        }
    }
}
