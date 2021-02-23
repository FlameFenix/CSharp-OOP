using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomlist = new RandomList();

            randomlist.Add("pesho");
            randomlist.Add("ivan");
            randomlist.Add("stoqn");

            randomlist.RandomString();

            foreach (var item in randomlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
