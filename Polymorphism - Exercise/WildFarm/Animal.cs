using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        private int foodEaten = 0;

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }
        public double Weight { get; set; }
        public int FoodEaten { get => this.foodEaten;
            set
            {
                this.foodEaten = value;
            }
        }

        public abstract void Sound();

        public abstract void Eat(Food food);

    }
}
