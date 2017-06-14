namespace _04.Add_VAT
{
    using System;
    using System.Linq;

    public class AddVAT
    {
        public static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            nums.Select(n => n * 1.2).ToList().ForEach(n => Console.WriteLine($"{n:F2}"));
        }
    }
}
