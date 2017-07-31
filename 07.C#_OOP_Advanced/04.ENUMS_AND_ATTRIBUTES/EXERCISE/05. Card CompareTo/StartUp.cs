using System;

public class StartUp
{
    public static void Main()
    {
        string cardPower1 = Console.ReadLine();
        string cardSuit1 = Console.ReadLine();

        string cardPower2 = Console.ReadLine();
        string cardSuit2 = Console.ReadLine();

        Rank power1 = (Rank)Enum.Parse(typeof(Rank), cardPower1);
        Suit suit1 = (Suit)Enum.Parse(typeof(Suit), cardSuit1);
        Card card1 = new Card(power1, suit1);

        Rank power2 = (Rank)Enum.Parse(typeof(Rank), cardPower2);
        Suit suit2 = (Suit)Enum.Parse(typeof(Suit), cardSuit2);
        Card card2 = new Card(power2, suit2);

        if (card1.CompareTo(card2) > 0)
        {
            Console.WriteLine(card1);
        }
        else
        {
            Console.WriteLine(card2);
        }
    }
}