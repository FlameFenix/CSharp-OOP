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
            List<Citizens> citizens = new List<Citizens>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();

                string name = cmdArgs[0];

                if (cmdArgs.Length == 2)
                {
                    string id = cmdArgs[1];
                    IRobot robot = new Citizens(name, id);
                    citizens.Add((Citizens)robot);
                    
                }
                else if (cmdArgs.Length == 3)
                {
                    int age = int.Parse(cmdArgs[1]);
                    string id = cmdArgs[2];
                    IPerson person = new Citizens(name, age, id);
                    citizens.Add((Citizens)person);
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
