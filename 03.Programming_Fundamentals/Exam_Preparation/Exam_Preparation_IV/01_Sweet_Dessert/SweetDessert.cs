namespace _01_Sweet_Dessert
{
    using System;

    public class SweetDessert
    {
        public static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            decimal bananaPriceUnit = decimal.Parse(Console.ReadLine());
            decimal eggsPriceUnit = decimal.Parse(Console.ReadLine());
            decimal berriesPriceKilo = decimal.Parse(Console.ReadLine());

            decimal portions = Math.Ceiling(guests / 6);
            decimal totalPrice  = portions * bananaPriceUnit * 2 + portions * eggsPriceUnit * 4 + portions * berriesPriceKilo * 0.20M;
            decimal neededMoney = totalPrice - cash;

            if (totalPrice <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
        }
    }
}
