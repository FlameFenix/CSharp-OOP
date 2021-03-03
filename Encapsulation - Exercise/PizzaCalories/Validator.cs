using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class Validator
    {
        public static void ValidateFlourName(string name, string message)
        {
                if (string.IsNullOrWhiteSpace(name) || name.ToLower() != "white" && name.ToLower() != "wholegrain")
                {
                    throw new ArgumentException(message);
                }
        }

        public static void ValidateBakingTechnique(string type, string message)
        {
            if(string.IsNullOrWhiteSpace(type) ||
                type.ToLower() != "crispy" &&
               type.ToLower() != "chewy"  &&
               type.ToLower() != "homemade")
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidateWeight(int currentValue, int minValue, int maxValue, string message)
        {
            if(currentValue < minValue || currentValue > maxValue)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidateToppingType(string type, string message)
        {
            if (string.IsNullOrWhiteSpace(type) ||
                type.ToLower() != "meat" &&
                type.ToLower() != "veggies" &&
                type.ToLower() != "cheese" &&
                type.ToLower() != "sauce")
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidateToppingWeight(int currentValue, int minValue, int maxValue, string message)
        {
            if(currentValue < minValue || currentValue > maxValue)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidatePizzaName(string name, string message)
        {
            if(name.Length < 1 || name.Length > 15 || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(message);
            }

        }

        public static void CheckToppingsCount(int count, string message)
        {
            if(count >= 11)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
