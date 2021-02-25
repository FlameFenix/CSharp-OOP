using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person(Console.ReadLine(), int.Parse(Console.ReadLine()));

            Console.WriteLine(person);
        }
    }
}