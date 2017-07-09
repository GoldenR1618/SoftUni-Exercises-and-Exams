namespace _01.Take_Two
{
    using System;
    using System.Linq;

    public class TakeTwo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Select(int.Parse).ToList().Where(n => n >= 10 && n <= 20).Distinct().Take(2).ToList()));
        }
    }
}
