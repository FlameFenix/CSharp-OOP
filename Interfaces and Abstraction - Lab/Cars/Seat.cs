using Cars.Conctracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        private string model;
        private string color;

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model
        {
            get => this.model;
            set
            {
                this.model = value;
            }
        }

        public string Color
        {
            get => this.color;
            set
            {
                this.color = value;
            }
        }

        public override string ToString()
        {
            return $"{Color} Seat {Model}";
        }
    }
}
