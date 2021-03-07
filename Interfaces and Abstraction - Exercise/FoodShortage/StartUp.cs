using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<IBuyer> citizens = new List<IBuyer>();

            int numberOfOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOperations; i++)
            {
                string input = Console.ReadLine();
                string[] cmdArgs = input.Split();

                if (cmdArgs.Length == 4)
                {
                    string name = cmdArgs[0];
                    int age = int.Parse(cmdArgs[1]);
                    string id = cmdArgs[2];
                    string birthdate = cmdArgs[3];
                    citizens.Add(new Citizen(name, age, id, birthdate));
                }
                else if (cmdArgs.Length == 3)
                {
                    string name = cmdArgs[0];
                    int age = int.Parse(cmdArgs[1]);
                    string group = cmdArgs[2];
                    citizens.Add(new Rebel(name, age, group));
                }
            }

            int sum = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "End")
                {
                    break;
                }

                IBuyer buyer = citizens.Find(x => x.Name == line);

                if(buyer != null)
                {
                    buyer.BuyFood();
                }
            }

            foreach (var item in citizens)
            {
                sum += item.Food;
            }

            Console.WriteLine(sum);
        }
    }
}
