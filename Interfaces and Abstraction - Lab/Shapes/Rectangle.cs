﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width 
        {
            get => this.width;
            private set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get => this.height;
            private set
            {
                this.height = value;
            }
        }

        public void Draw()
        {
            for (int rows = 0; rows < this.Width; rows++)
            {
                for (int cols = 0; cols < this.Height; cols++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
