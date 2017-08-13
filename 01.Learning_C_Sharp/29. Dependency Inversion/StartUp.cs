namespace Dependency_Inversion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Types of Dependency Injections:
            //  Constructor injection:
            //      Pros: Classes self-documenting requirements, Works well without container, Always valid state.
            //      Cons: Many parameters, Methods may not need everything.
            //  Property injection.
            //  Parameters injection.

            Copy copy = new Copy(new ConsoleReader(), new FileWriter("out.txt"));
        }
    }

    public interface IReader
    {
    }

    public interface IWriter
    {
    }

    public class FileWriter : IWriter
    {
        public FileWriter(string fileName)
        {
            throw new NotImplementedException();
        }
    }

    public class ConsoleReader : IReader
    {
    }

    public class Copy
    {
        private IReader reader;
        private IWriter writer;

        public Copy(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        // Read/Write data through the reader/writer
    }
}
