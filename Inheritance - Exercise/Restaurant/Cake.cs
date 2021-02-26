using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        // should set grams, calories, cakeprice TO DEFAULTVALUES! ! !
        const double grams = 250;
        const double calories = 1000;
        const decimal cakeprice = 5;

        public Cake(string name)
            : base(name, cakeprice, grams, calories)
        {

        }
    }
}
