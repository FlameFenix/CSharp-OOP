﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {

        }

        public override void Eat(Food food)
        {
            Weight += 0.35 * food.Quantity;
            FoodEaten += food.Quantity;
        }

        public override void Sound()
        {
            Console.WriteLine("Cluck");
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
