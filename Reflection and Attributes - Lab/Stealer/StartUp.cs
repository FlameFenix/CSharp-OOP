using System;

namespace Stealer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();

            string stealInfo = spy.StealFieldInfo("Stealer.Hacker", new string[] { "username", "password" });

            Console.WriteLine(stealInfo);
        }
    }
}
