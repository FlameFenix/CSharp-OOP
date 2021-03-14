using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class Music : StreamProgressInfo
    {
        private string artist;
        private string album;

        public Music(int length, int bytesSent, string artist, string album) 
            : base(length, bytesSent)
        {
            this.artist = artist;
            this.album = album;
        }
    }
}
