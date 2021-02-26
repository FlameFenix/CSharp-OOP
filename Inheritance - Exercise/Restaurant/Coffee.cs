using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        const decimal CoffePrice = 3.50M;
        const double CoffeeMililiters = 50;

        public Coffee(string name, double caffeine)
            : base(name, CoffePrice, CoffeeMililiters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
