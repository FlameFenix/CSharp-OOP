using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {

        }

        public override void Eat(Food food)
        {
            if(!(food.GetType().Name == nameof(Foods.Vegetable) || food.GetType().Name == nameof(Foods.Fruit)))
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                this.Weight += 0.10 * food.Quantity;
                FoodEaten += food.Quantity;
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Squeak");
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
