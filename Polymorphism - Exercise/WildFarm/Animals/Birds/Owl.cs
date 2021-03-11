using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {

        }

        public override void Eat(Food food)
        {
            if(!(food.GetType().Name == nameof(Foods.Meat)))
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                this.Weight += 0.25 * food.Quantity;
                FoodEaten += food.Quantity;
            }
            
        }

        public override void Sound()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
