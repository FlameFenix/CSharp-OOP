using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int minValue = 1;
        private const int maxValue = 50;

        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type 
        {
            get => this.type;
            private set
            {
                Validator.ValidateToppingType(value, $"Cannot place {value} on top of your pizza.");
                this.type = value;
            }
        }

        public int Weight 
        {
            get => this.weight;
            private set
            {
                Validator.ValidateToppingWeight(value, minValue, maxValue, $"{this.Type} weight should be in the range [1..50].");
            }
        }
    }
}
