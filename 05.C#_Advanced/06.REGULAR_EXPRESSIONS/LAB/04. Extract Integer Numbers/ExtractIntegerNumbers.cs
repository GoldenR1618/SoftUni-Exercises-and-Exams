namespace _04.Extract_Integer_Numbers
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractIntegerNumbers
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\d+");

            MatchCollection matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
