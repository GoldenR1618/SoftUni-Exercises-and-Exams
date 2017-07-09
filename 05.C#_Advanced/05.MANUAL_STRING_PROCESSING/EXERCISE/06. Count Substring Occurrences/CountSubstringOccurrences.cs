namespace _06.Count_Substring_Occurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();         //aaaaaa
            string pattern = Console.ReadLine().ToLower();      //aa

            int startIndex = 0;
            int count = 0;

            while (true)                                        //Ако няма съвпадение между патерна и текста, IndexOf връща -1.
            {
                int found = text.IndexOf(pattern, startIndex);

                if (found >= 0)
                {
                    count++;
                    startIndex = found + 1;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine(count);
        }
    }
}
