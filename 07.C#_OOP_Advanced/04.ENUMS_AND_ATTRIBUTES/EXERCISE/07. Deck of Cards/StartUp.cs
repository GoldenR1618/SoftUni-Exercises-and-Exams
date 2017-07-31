using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        Console.ReadLine();
        string[] ranks = Enum.GetNames(typeof(Rank));
        string[] suits = Enum.GetNames(typeof(Suit));

        foreach (var suit in suits)
        {
            Console.WriteLine($"{Rank.Ace} of {suit}");
            Console.WriteLine(string.Join(Environment.NewLine, ranks.Take(ranks.Length - 1).Select(r => $"{r} of {suit}")));
        }
    }
}
