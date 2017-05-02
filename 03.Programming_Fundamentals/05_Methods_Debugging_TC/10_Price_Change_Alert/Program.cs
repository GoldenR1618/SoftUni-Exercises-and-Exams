using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double difference = Proc(price, nextPrice);
            bool isSignificantDifference = IsEnoughDiff(difference, threshold);
            string message = Get(nextPrice, price, difference, isSignificantDifference);
            Console.WriteLine(message);
            price = nextPrice;
        }
    }
    private static string Get(double nextPrice, double price, double difference, bool etherTrueOrFalse)
    {
        string to = "";
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", nextPrice);
            return to;
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            return to;
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            return to;
        }
        else if (etherTrueOrFalse && (difference < 0))
        {
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            return to;
        }
        return to;
    }
    private static bool IsEnoughDiff(double threshold, double isDiff)
    {
        if (Math.Abs(threshold) >= isDiff)
        {
            return true;
        }
        return false;
    }
    private static double Proc(double price, double nextPrice)
    {
        double difference = (nextPrice - price) / price;
        return difference;
    }
}