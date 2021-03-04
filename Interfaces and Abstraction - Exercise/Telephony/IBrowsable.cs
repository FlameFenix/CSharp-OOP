using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface IBrowsable
    {
        public string Website { get; }

        public void Browse(string website);
    }
}
