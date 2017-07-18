namespace _01_Charity_Marathon
{
    using System;


    public class CharityMarathon
    {
        public static void Main(string[] args)
        {
            decimal days = decimal.Parse(Console.ReadLine());
            decimal runners = decimal.Parse(Console.ReadLine());
            decimal averageLapsPerRunner = decimal.Parse(Console.ReadLine());
            decimal trackLength = decimal.Parse(Console.ReadLine());
            decimal trackCapacity = decimal.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            decimal maxRunner = trackCapacity * averageLapsPerRunner;
            decimal totalRunners = Math.Min(runners, days * trackCapacity);

            decimal totalMeters = totalRunners * averageLapsPerRunner * trackLength;
            decimal totalKilometers = totalMeters / 1000;
            decimal money = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {money:F2}");
        }
    }
}
