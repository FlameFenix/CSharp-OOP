using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public interface IPerson : IIdentifiable
    {
        public string Name { get; }
        public int Age { get; }
    }
}
