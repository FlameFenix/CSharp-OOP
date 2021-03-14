namespace P01.Stream_Progress
{
    public class File : StreamProgressInfo
    {
        private string name;

        public File(int length, int bytesSent, string name) 
            : base(length, bytesSent)
        {
            this.name = name;
        }
    }
}
