using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {

        }

        public override void Eat(Food food)
        {
            if (!(food.GetType().Name == nameof(Foods.Meat)))
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                this.Weight += 1.00 * food.Quantity;
                FoodEaten += food.Quantity;
            }
        }

        public override void Sound()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
