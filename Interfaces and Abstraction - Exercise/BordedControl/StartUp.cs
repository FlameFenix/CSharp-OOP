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

            List<IIdentifiable> citizens = new List<IIdentifiable>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();

                string name = cmdArgs[0];

                if (cmdArgs.Length == 2)
                {
                    string id = cmdArgs[1];
                    citizens.Add(new Robot(name, id));
                    
                }
                else if (cmdArgs.Length == 3)
                {
                    int age = int.Parse(cmdArgs[1]);
                    string id = cmdArgs[2];
                    citizens.Add(new Citizen(name,age, id));
                }
            }

            string contains = Console.ReadLine();

            foreach (var item in citizens)
            {
                if(item.Id.EndsWith(contains))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}
