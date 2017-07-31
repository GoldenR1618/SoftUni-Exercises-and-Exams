using System;

public class Card : IComparable<Card>
{
    private Rank rank;
    private Suit suit;
    private int power;

    public Card(Rank rank, Suit suit)
    {
        this.Rank = rank;
        this.Suit = suit;
        this.power = (int)this.rank + (int)this.suit;
    }

    public Rank Rank
    {
        get { return this.rank; }
        private set { this.rank = value; }
    }
    public Suit Suit
    {
        get { return this.suit; }
        private set { this.suit = value; }
    }

    public int Power
    {
        get { return this.power; }
        private set { this.power = value; }
    }

    public int CompareTo(Card other)
    {
        return this.power - other.power;
    }

    public override string ToString()
    {
        return $"Card name: {this.rank} of {this.suit}; Card power: {this.power}";
    }
}
