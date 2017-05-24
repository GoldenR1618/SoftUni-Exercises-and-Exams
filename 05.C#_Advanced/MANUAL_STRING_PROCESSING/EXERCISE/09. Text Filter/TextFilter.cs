namespace _09.Text_Filter
{
    using System;

    public class TextFilter
    {
        public static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new string[] { ", "}, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
