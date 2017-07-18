using System;

class SweetDesert
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        int guestCount = int.Parse(Console.ReadLine());
        decimal bananaPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPrice = decimal.Parse(Console.ReadLine());

        int portionsCount = (int)Math.Ceiling(guestCount / 6.0);

        decimal totalDinnerPrice = (portionsCount * bananaPrice * 2) + (portionsCount * eggsPrice * 4) + (portionsCount * berriesPrice * 0.2m);

        if (cash >= totalDinnerPrice)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {totalDinnerPrice:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalDinnerPrice - cash):f2}lv more.");
        }
    }
}