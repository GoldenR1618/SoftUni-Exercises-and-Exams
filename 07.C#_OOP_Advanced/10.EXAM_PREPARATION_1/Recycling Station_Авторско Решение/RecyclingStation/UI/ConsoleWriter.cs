namespace RecyclingStation.UI
{
    using System;
    using RecyclingStation.Interfaces.UI;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
