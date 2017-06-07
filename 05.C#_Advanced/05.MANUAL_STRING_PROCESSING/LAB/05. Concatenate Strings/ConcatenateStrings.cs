namespace _05.Concatenate_Strings
{
    using System;
    using System.Text;

    public class ConcatenateStrings
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                sb.Append(word);
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
