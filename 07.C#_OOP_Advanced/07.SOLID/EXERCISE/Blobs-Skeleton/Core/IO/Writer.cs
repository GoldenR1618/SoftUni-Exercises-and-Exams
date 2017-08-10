namespace _02.Blobs.Core.IO
{
    using System;
    using _02.Blobs.Interfaces.IO;

    public class Writer : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}