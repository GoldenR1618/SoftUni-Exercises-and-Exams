namespace Logger.Core.IO
{
    using System;
    using Interfaces;

    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}