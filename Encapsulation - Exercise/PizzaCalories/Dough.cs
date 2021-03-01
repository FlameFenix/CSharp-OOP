using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int minValueWeight = 1;
        private const int maxValueWeight = 200;

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flour, string bakingtech, int weight)
        {
            FlourType = flour;
            BakingTechnique = bakingtech;
            Weight = weight;
        }

        public string FlourType 
        {
            get => this.flourType;
            private set
            {
                Validator.ValidateFlourName(value, "Invalid type of dough.");
                this.flourType = value;
            }
        }

        public string BakingTechnique 
        {
            get => this.bakingTechnique;
            private set
            {
                Validator.ValidateBakingTechnique(value, "Invalid type of dough.");
                this.bakingTechnique = value;
            }
        }

        public int Weight
        {
            get => this.weight;
            private set
            {
                Validator.ValidateWeight(value, minValueWeight, maxValueWeight, $"Dough weight should be in the range [{minValueWeight}..{maxValueWeight}].");
                this.weight = value;
            }
        }

    }
}
