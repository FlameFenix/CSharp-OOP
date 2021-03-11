using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {

        }

        public override void Eat(Food food)
        {
            if (!(food.GetType().Name == nameof(Foods.Vegetable) || food.GetType().Name == nameof(Foods.Meat)))
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                this.Weight += 0.30 * food.Quantity;
                FoodEaten += food.Quantity;
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
