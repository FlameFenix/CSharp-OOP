using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<string> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
        }

        public string Name 
        {
            get => this.name;
            private set
            {
                Validator.ValidatePizzaName(value, "Pizza name should be between 1 and 15 symbols.");
            }
        }

        public Dough Dough { get; set; }
    }
}
