using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class Validator
    {
        // Make sure that if invalid flour type or an invalid baking technique is given
        // a proper Exception is thrown with the message "Invalid type of dough.".

        public static void ValidateFlourName(string name, string message)
        {
                if (name.ToLower() != "white" && name.ToLower() != "wholegrain")
                {
                    throw new ArgumentException(message);
                }
        }

        public static void ValidateBakingTechnique(string type, string message)
        {
            //crispy, chewy or homemade.

            if(type.ToLower() != "crispy" &&
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
            //•	Meat - 1.2;
            //•	Veggies - 0.8;
            //•	Cheese - 1.1;
            //•	Sauce - 0.9;

            if (type.ToLower() != "meat" &&
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
            if(string.IsNullOrWhiteSpace(name) && name.Length < 1 && name.Length > 15)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
