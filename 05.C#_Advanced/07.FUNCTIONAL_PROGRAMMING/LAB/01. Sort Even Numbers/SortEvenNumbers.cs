namespace _01.Sort_Even_Numbers
{
    using System;
    using System.Linq;

    public class SortEvenNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(n => n % 2 == 0).OrderBy(n => n).ToList()));
        }
    }
}
