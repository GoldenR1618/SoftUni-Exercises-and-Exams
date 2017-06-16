namespace _04.Average_of_Doubles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageOfDoubles
    {
        public static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            Console.WriteLine($"{nums.Average():F2}");
        }
    }
}
