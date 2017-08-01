using System;
using System.Linq;

[Info("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
public class StartUp
{
    public static void Main()
    {
        InfoAttribute info = (InfoAttribute)typeof(StartUp).GetCustomAttributes(false).First();

        string command = Console.ReadLine();

        while (command != "END")
        {
            switch (command)
            {
                case "Author":
                    Console.WriteLine($"Author: {info.Author}");
                    break;

                case "Revision":
                    Console.WriteLine($"Revision: {info.Revision}");
                    break;

                case "Description":
                    Console.WriteLine($"Class description: {info.Description}");
                    break;

                case "Reviewers":
                    Console.WriteLine($"Reviewers: {string.Join(", ", info.Reviewers)}");
                    break;

                default:
                    break;
            }
            
            command = Console.ReadLine();
        }
    }
}