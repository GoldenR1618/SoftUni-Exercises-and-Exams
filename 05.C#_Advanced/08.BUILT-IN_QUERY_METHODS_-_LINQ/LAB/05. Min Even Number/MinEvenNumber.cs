namespace _05.Min_Even_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinEvenNumber
    {
        public static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            double result = nums.Where(n => n % 2 == 0).OrderBy(n => n).FirstOrDefault();

            if (result != 0)
            {
                Console.WriteLine($"{result:F2}");
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
