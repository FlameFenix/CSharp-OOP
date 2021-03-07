using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public interface IBirthdate : IBuyer
    {
        public string Birthdate { get; }
    }
}
