using System;
using System.Collections.Generic;
using System.Text;

namespace BordedControl
{
    public interface IIdentifiable : IBirthdate
    {
        public string Id { get; }
    }
}
