namespace _03.Non_Digit_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class NonDigitCount
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"\D");
            Console.WriteLine($"Non-digits: { regex.Matches(text).Count}");
        }
    }
}
