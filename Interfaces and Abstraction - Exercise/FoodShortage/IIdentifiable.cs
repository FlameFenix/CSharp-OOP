using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public interface IIdentifiable : IBirthdate
    {
        public string Id { get; }
    }
}
