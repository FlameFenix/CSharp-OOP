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

        private string FlourType 
        {
            get => this.flourType;
            set
            {
                Validator.ValidateFlourName(value, "Invalid type of dough.");
                this.flourType = value;
            }
        }

        private string BakingTechnique 
        {
            get => this.bakingTechnique;
            set
            {
                Validator.ValidateBakingTechnique(value, "Invalid type of dough.");
                this.bakingTechnique = value;
            }
        }

        private int Weight
        {
            get => this.weight;
            set
            {
                Validator.ValidateWeight(value, minValueWeight, maxValueWeight, $"Dough weight should be in the range [{minValueWeight}..{maxValueWeight}].");
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
            double flour = 0;
            double bakingType = 0;

            if(FlourType.ToLower() == "white")
            {
                flour = 1.5;
            } 
            else if(FlourType.ToLower() == "wholegrain")
            {
                flour = 1.0;
            }

            if(bakingTechnique.ToLower() == "crispy")
            {
                bakingType = 0.9;
            }
            else if(BakingTechnique.ToLower() == "chewy")
            {
                bakingType = 1.1;
            }
            else if(BakingTechnique.ToLower() == "homemade")
            {
                bakingType = 1.0;
            }

            double calories = (2 * this.weight) * flour * bakingType;
            return calories;
        }
    }
}
