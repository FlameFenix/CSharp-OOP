﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BordedControl
{
    public interface IRobot : IIdentifiable
    {
        public string Model { get; }
    }
}
