namespace RecyclingStation.Core
{
    using System;
    using System.Reflection;
    using RecyclingStation.Interfaces;
    using RecyclingStation.Interfaces.UI;
    using RecyclingStation.UI;

    public class Engine : IEngine
    {
        public Engine(ICommandHandler commandHandler, IReader reader, IWriter writer)
        {
            this.CommandHandler = commandHandler;
            this.Reader = reader;
            this.Writer = writer;
        }

        public Engine() : this(new CommandHandler(), new ConsoleReader(), new ConsoleWriter())
        {
        }

        public ICommandHandler CommandHandler { get; private set; }

        public IReader Reader { get; private set; }

        public IWriter Writer { get; private set; }

        public void Run()
        {
            string line = this.Reader.ReadLine();
            while (line != "TimeToRecycle")
            {
                string[] tokens = line.Split();
                string methodName = tokens[0];
                object[] invokeParams = new object[0];
                if (tokens.Length > 1)
                {
                    invokeParams = new object[1];
                    invokeParams[0] = tokens[1].Split('|');
                }

                try
                {
                    MethodInfo method = this.CommandHandler.GetType().GetMethod(methodName);
                    if (method == null)
                    {
                        throw new ArgumentException("The passed in command is invalid!");
                    }
                    this.Writer.WriteLine((string)method.Invoke(this.CommandHandler, invokeParams));
                }
                catch (ArgumentException ex)
                {
                    this.Writer.WriteLine(ex.Message);
                }

                line = Reader.ReadLine();
            }
        }
    }
}
