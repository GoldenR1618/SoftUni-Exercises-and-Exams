using System;

public class StartUp
{
    public static void Main()
    {
        string cardPower = Console.ReadLine();
        string cardSuit = Console.ReadLine();

        Rank power = (Rank)Enum.Parse(typeof(Rank), cardPower);
        Suit suit = (Suit)Enum.Parse(typeof(Suit), cardSuit);

        Console.WriteLine(new Card(power, suit));
    }
}
