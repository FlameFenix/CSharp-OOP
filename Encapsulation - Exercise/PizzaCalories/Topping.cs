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

        private string Type
        {
            get => this.type;
            set
            {
                Validator.ValidateToppingType(value, $"Cannot place {value} on top of your pizza.");
                this.type = value;
            }
        }

        private int Weight
        {
            get => this.weight;
            set
            {
                Validator.ValidateToppingWeight(value, minValue, maxValue, $"{this.Type} weight should be in the range [{minValue}..{maxValue}].");
                this.weight = value;
            }
        }
        public double Calories
        {
            get
            {
                return GetCalories();
            }
            private set
            {
                Calories = GetCalories();
            }
        }

        private double GetCalories()
        {
            double type = 0;

            if (Type.ToLower() == "meat")
            {
                type = 1.2;
            }
            else if (Type.ToLower() == "veggies")
            {
                type = 0.8;
            }
            else if (Type.ToLower() == "cheese")
            {
                type = 1.1;
            }
            else if (Type.ToLower() == "sauce")
            {
                type = 0.9;
            }

            double calories = 2 * this.Weight * type;
            return calories;
        }
    }
}
