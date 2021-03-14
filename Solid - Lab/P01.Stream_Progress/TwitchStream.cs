using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class TwitchStream : StreamProgressInfo
    {
        private string name;

        public TwitchStream(int length, int bytesSent, string twitchName) 
            : base(length, bytesSent)
        {
            this.name = twitchName;
        }
    }
}
