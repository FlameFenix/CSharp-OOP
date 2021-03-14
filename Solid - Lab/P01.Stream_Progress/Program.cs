using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            StreamProgressInfo file = new File(10, 20, "pesho");

            Console.WriteLine(file.CalculateCurrentPercent());

            StreamProgressInfo music = new Music(5, 20, "ivan", "dragan");

            Console.WriteLine(music.CalculateCurrentPercent());

            StreamProgressInfo twitch = new TwitchStream(5, 15, "name");

            Console.WriteLine(twitch.CalculateCurrentPercent());
        }
    }
}
