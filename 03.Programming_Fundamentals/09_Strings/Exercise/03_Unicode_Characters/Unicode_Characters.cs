namespace _03_Unicode_Characters
{
    using System;
    using System.Text;

    public class Unicode_Characters
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetUnicodeString(input));
        }

        public static string GetUnicodeString(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char ch in input)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)ch));
            }
            return sb.ToString();
        }
    }
}
