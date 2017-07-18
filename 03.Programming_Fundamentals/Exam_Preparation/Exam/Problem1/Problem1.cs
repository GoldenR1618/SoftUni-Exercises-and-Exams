namespace Problem1
{
    using System;

    public class Problem1
    {
        public static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distanceFor1000flapsMeters = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            double distance = (int)(wingFlaps / 1000) * distanceFor1000flapsMeters;
            long timeFlapsSec = (wingFlaps / 100);
            long rest = (wingFlaps / endurance) * 5;
            long sum = timeFlapsSec + rest;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{sum} s.");
        }
    }
}
