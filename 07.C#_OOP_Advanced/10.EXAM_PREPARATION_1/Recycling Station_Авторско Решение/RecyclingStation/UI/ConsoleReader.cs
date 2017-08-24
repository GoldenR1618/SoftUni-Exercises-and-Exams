namespace RecyclingStation.UI
{
    using System;
    using RecyclingStation.Interfaces.UI;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
