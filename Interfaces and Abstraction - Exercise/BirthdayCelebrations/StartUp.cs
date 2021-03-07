using System;
using System.Collections.Generic;
using System.Linq;

namespace BordedControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<IBirthdate> citizens = new List<IBirthdate>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();

                string type = cmdArgs[0];
                string name = cmdArgs[1];

                if(type == nameof(Citizen))
                {
                    int age = int.Parse(cmdArgs[2]);
                    string id = cmdArgs[3];
                    string birthdate = cmdArgs[4];
                    citizens.Add(new Citizen(name, age, id, birthdate));
                }
                else if(type == nameof(Pet))
                {
                    string birthdate = cmdArgs[2];
                    citizens.Add(new Pet(name, birthdate));
                }
            }

            string contains = Console.ReadLine();

            foreach (var item in citizens)
            {
                if (item.Birthdate.Contains(contains))
                {
                    Console.WriteLine(item.Birthdate);
                }
            }
        }
    }
}
