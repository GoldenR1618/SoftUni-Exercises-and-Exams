namespace _06.Find_and_Sum_Integers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindAndSumIntegers
    {
        public static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split(' ')
                .Select(n => { long value; bool success = long.TryParse(n, out value); return new { value, success }; })
                .Where(b => b.success)
                .Select(x => x.value)
                .ToList();

            if (numbers.Count != 0)
            {
                Console.WriteLine(numbers.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
