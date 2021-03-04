using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string[] websites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in numbers)
            {
                try
                {
                    if (item.Length == 7)
                    {
                        ICallable stationary = new StationaryPhone();
                        stationary.Call(item);
                    }
                    else if (item.Length == 10)
                    {
                        ICallable smartphone = new Smartphone();
                        smartphone.Call(item);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            IBrowsable phone = new Smartphone();

            foreach (var item in websites)
            {
                try
                {
                    phone.Browse(item);
                }
                catch (Exception ex )
                {
                    Console.WriteLine(ex.Message);
                }
                 
            }
        }
    }
}
