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
    }
}
