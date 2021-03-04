using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    class StationaryPhone : ICallable
    {
        public string Number { get; private set; }

        public void Call(string number)
        {
            if (number.Any(x => char.IsDigit(x)))
            {
                Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                throw new ArgumentException("Invalid number!");
            }
        }
    }
}
