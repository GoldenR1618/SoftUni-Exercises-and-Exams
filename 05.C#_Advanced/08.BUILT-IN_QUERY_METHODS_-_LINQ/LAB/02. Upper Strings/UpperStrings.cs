namespace _02.Upper_Strings
{
    using System;
    using System.Linq;

    public class UpperStrings
    {
        public static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');
            string[] result = text.Select(w => w.ToUpper()).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
