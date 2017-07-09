namespace _02.Vowel_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class VowelCount
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"[aeiouyAEIOUY]");
            Console.WriteLine($"Vowels: { regex.Matches(text).Count}");
        }
    }
}
