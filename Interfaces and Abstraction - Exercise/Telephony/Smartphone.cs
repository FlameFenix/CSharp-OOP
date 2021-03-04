using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    class Smartphone : ICallable, IBrowsable
    {

        public string Number { get; private set; }

        public string Website { get; private set; }

        public void Call(string number)
        {
            bool isValidNumber = number.Any(x => !char.IsDigit(x));

            if(isValidNumber)
            {
                throw new ArgumentException("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Calling... {number}");
            }
        }

        public void Browse(string website)
        {
            if(website.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {website}!");
            }
        }
    }
}
