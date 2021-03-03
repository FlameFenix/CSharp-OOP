using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough, List<Topping> toppings)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validator.ValidatePizzaName(value, "Pizza name should be between 1 and 15 symbols.");
                this.name = value;
            }
        }

        private Dough Dough
        {
            get => this.dough;
            set
            {
                this.dough = value;
            }
        }

        private List<Topping> Toppings
        {
            get => this.toppings;
            set
            {
                this.toppings = value;
            }
        }

        private int Count { get => this.Toppings.Count; }

        public double Calories 
        {
            get 
            { 
                return GetTotalCalories(); 
            }
            private set
            {
                Calories = GetTotalCalories();
            }
        }

        public void AddTopings(Topping topping)
        {
            Validator.CheckToppingsCount(this.Toppings.Count, "Number of toppings should be in range [0..10].");
            Toppings.Add(topping);
        }

        private double GetTotalCalories()
        {
            double doughCalories = 0;
            double toppingCalories = 0;

            doughCalories = Dough.Calories;

            foreach (var item in toppings)
            {
                toppingCalories += item.Calories;
            }

            double totalCalories = doughCalories + toppingCalories;
            return totalCalories;
        }
    }
}
