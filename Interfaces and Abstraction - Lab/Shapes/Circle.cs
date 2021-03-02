using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius 
        {
            get => this.radius;
            private set
            {
                this.radius = value;
            }
        }

        public void Draw()
        {
            double rIn = this.Radius - 0.4;
            double rOut = this.Radius + 0.4;

            for (double rows = this.Radius; rows >= -this.Radius ; --rows)
            {
                for (double cols = -this.Radius; cols < rOut; cols += 0.5)
                {
                    double value = rows * rows + cols * cols;
                    if(value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
