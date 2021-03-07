﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BordedControl
{
    public interface IPerson : IIdentifiable
    {
        public string Name { get; }
        public int Age { get; }
    }
}
