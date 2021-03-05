using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favouriteFood;
        }

        public string Name { get => this.name; private set { this.name = value; } }
        public string FavoriteFood { get => this.favouriteFood; private set {this.favouriteFood = value; } }

        public virtual string ExplainSelf()
        {
            return string.Empty;
        }
    }
}
