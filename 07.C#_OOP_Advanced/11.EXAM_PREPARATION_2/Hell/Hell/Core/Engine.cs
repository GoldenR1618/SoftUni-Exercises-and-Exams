using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private InputReader reader;
    private OutputWriter writer;
    private HeroManager heroManager;

    public Engine(InputReader reader, OutputWriter writer, HeroManager heroManager)
    {
        this.reader = reader;
        this.writer = writer;
        this.heroManager = heroManager;
    }

    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            string inputLine = this.reader.ReadLine();
            List<string> arguments = this.parseInput(inputLine);
            this.writer.WriteLine(this.processInput(arguments));
            isRunning = !this.ShouldEnd(inputLine);
        }
    }

    private static List<string> parseInput(string input)
    {
        return input.Split(' ').ToList();
    }

    private static string processInput(List<string> arguments)
    {
        string command = arguments[0];
        arguments.RemoveAt(0);

        Type commandType = Type.GetType(command + "Command");
        var constructor = commandType.GetConstructor(new Type[] { typeof(IList<string>), typeof(IManager) });
        Command cmd = (Command)constructor.Invoke(new object[] { arguments, this.heroManager });
        return cmd.Execute();
    }

    private static bool ShouldEnd(string inputLine)
    {
        return inputLine.Equals("Quit");
    }
}