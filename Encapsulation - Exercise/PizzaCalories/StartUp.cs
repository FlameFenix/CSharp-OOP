using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] pizzaInfo = Console.ReadLine().Split().ToArray();

            string[] doughInfo = Console.ReadLine().Split().ToArray();

            try
            {
                string doughType = doughInfo[1];
                string doughTechnique = doughInfo[2];
                int doughGrams = int.Parse(doughInfo[3]);

                string pizzaName = pizzaInfo[1];

                Dough dough = new Dough(doughType, doughTechnique, doughGrams);

                Pizza pizza = new Pizza(pizzaName, dough, new List<Topping>());

                string command = string.Empty;

                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmdArgs = command.Split().ToArray();
                    string toppingType = cmdArgs[1];
                    int toppingGrams = int.Parse(cmdArgs[2]);

                    Topping topping = new Topping(toppingType, toppingGrams);

                    pizza.AddTopings(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }
    }
}
