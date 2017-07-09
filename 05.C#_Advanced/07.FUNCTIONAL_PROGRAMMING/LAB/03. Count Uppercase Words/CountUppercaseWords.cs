namespace _03.Count_Uppercase_Words
{
    using System;
    using System.Linq;

    public class CountUppercaseWords
    {
        public static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            text.Where(checker).ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}
