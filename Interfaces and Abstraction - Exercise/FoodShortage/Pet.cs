using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Pet
    { 
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }
        public string Birthdate { get; private set; }
    }
}
