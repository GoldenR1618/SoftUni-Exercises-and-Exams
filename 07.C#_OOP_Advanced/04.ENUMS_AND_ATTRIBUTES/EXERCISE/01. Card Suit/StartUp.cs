using System;

public class StartUp
{
    public static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine($"{input}:");

        Array suits = Enum.GetValues(typeof(CardSuits));

        foreach (var suit in suits)
        {
            Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
        }
    }
}
