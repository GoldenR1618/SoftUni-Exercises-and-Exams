namespace _03.Series_Of_Numbers
{
    using System;

    public class SeriesOfNumbers
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(Filtertetxt(text));
        }

        private static string Filtertetxt(string text)
        {
            string result = text[0].ToString();

            for (int i = 0; i < text.Length - 1; i++)
            {
                string current = text[i].ToString();
                string next = text[i + 1].ToString();

                if (current == next)
                {
                    continue;
                }

                result += next;
            }

            return result;
        }
    }
}
