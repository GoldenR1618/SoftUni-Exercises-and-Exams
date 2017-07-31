using System;
using System.Collections.Generic;
using System.Linq;

public class CardGame
{
    private string winner;
    private Card winningCard;
    private HashSet<Card> cardsInPlayers;

    public CardGame()
    {
        this.cardsInPlayers = new HashSet<Card>();
    }

    public void Run()
    {
        string player1 = Console.ReadLine();
        string player2 = Console.ReadLine();

        this.GetFiveCards(player1);
        this.GetFiveCards(player2);

        Console.WriteLine($"{this.winner} wins with {this.winningCard.Rank} of {this.winningCard.Suit}.");
    }

    private void GetFiveCards(string player)
    {
        int counter = 0;

        while (counter < 5)
        {
            string[] input = Console.ReadLine().Split();
            string rankName = input[0];
            string suitName = input[2];

            bool isRankValid = Enum.TryParse(rankName, out Rank rank);
            bool isSuitValid = Enum.TryParse(suitName, out Suit suit);

            if (!isRankValid || !isSuitValid)
            {
                Console.WriteLine("No such card exists.");
                continue;
            }

            Card card = new Card(rank, suit);

            if (this.cardsInPlayers.Any(c => c.CompareTo(card) == 0))
            {
                Console.WriteLine("Card is not in the deck.");
                continue;
            }

            this.cardsInPlayers.Add(card);
            this.MaxCardChecker(card, player);
            counter++;
        }
    }

    private void MaxCardChecker(Card card, string player)
    {
        if (this.winningCard == null)
        {
            this.winningCard = card;
            this.winner = player;
            return;
        }

        if (card.CompareTo(this.winningCard) > 0)
        {
            this.winningCard = card;
            this.winner = player;
        }
    }
}
