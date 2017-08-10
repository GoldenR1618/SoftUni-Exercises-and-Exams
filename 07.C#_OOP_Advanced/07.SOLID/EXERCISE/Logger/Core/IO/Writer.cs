namespace Logger.Core.IO
{
    using System;
    using Interfaces;

    public class Writer : IWriter
    {
        public void WriteLine(string content)
        {
            Console.WriteLine(content);
        }
    }
}