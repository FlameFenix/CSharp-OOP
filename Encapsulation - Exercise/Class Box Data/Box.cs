using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length { 
            get
            {
                return this.length;
            }
                
            private set
            {
                

                if(value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            } 
        }

        public double Width { get
            {
               return this.width;
            } 
            private set
            {
                   
                    if (value <= 0)
                    {
                    throw new ArgumentException("Width cannot be zero or negative.");
                    }

                this.width = value;

            }
        }

        public double Height { get 
            {
                return this.height; 
            } 
            private set 
            {
                
                if (value <= 0)
                    
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            } 
        }

        public double SurfaceArea(double length, double width, double height)
        {
            return (2 * (Length * Width)) + (2 * (Length * Height)) + (2 * (Width * Height));
        }

        public double LateralSurfaceArea(double length, double width, double height)
        {
            return 2 * (Length * Height) + 2 * (Width * Height);
        }

        public double Volume(double length, double width, double height)
        {
            return (Length * Width * Height);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {SurfaceArea(this.length, this.width, this.height):f2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea(this.length, this.width, this.height):f2}");
            sb.AppendLine($"Volume - {Volume(this.length, this.width, this.height):f2}");
            return sb.ToString().Trim();
        }
    }
}
