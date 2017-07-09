namespace _03_Text_Filter
{
    using System;

    public class TextFilter
    {
        public static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine()
             .Split(new char[] { '\n', ',', ';', ':', '.', '!', '(', ')', '"', '-', '\\',
                 '/', '[', ']', ' ', '?', '\r', '`', '_', '{', '}', '<', '>', '\'' },
                 StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var item in banWords)
            {
                text = text.Replace(item, new string('*', item.Length));
            }

            Console.WriteLine(text);
        }
    }
}
