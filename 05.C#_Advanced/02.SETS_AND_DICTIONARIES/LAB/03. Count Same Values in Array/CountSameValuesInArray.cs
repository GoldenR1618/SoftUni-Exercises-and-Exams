namespace _03.Count_Same_Values_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class CountSameValuesInArray
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double[] numbers = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(n => double.Parse(n, CultureInfo.InvariantCulture)).ToArray();

            var dictionary = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary.Add(number, 1);
                }
                else
                {
                    dictionary[number]++;
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
