using System;

public class StartUp
{
    public static void Main()
    {
        string targetEnum = Console.ReadLine();

        Type enumType = targetEnum == "Rank" ? typeof(Rank) : typeof(Suit);

        Console.WriteLine(string.Join(Environment.NewLine, enumType.GetCustomAttributes(false)));
    }
}
