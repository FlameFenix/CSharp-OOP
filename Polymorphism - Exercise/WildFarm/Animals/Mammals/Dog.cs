using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
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
                this.Weight += 0.40 * food.Quantity;
                FoodEaten += food.Quantity;
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Woof!");
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
