using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public abstract class StreamProgressInfo : IStreamProgressInfo
    {

        public int Length { get; private set; }

        public int BytesSent { get; private set; }

        public StreamProgressInfo(int length, int bytesSent)
        {
            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public int CalculateCurrentPercent()
        {
            return (this.BytesSent * 100) / this.Length;
        }


    }
}
