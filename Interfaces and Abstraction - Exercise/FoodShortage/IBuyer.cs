﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public interface IBuyer
    {
        public string Name { get; }
        public int Food { get; }

        public int BuyFood();
    }
}