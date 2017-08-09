namespace _01.Stream_Progress
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            IStreamable file = new File("File name", 1234, 123);
            StreamProgressInfo fileProcessInfo = new StreamProgressInfo(file);
            Console.WriteLine(fileProcessInfo.CalculateCurrentPercent());

            IStreamable music = new Music("Singer", "Album", 123456, 12349);
            StreamProgressInfo musicProcessInfo = new StreamProgressInfo(music);
            Console.WriteLine(musicProcessInfo.CalculateCurrentPercent());
        }
    }
}
