﻿using System;

namespace Collector
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.CollectGettersAndSetters("Collector.Hacker");
            Console.WriteLine(result);
        }
    }
}
