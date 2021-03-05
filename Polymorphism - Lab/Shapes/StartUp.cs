using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(5,6);
            Console.WriteLine(rectangle.Draw());
        }
    }
}
