namespace _01.Reverse_String
{
    using System;
    using System.Text;

    public class ReverseString
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ReverseInput(Console.ReadLine()));
        }

        private static string ReverseInput(string v)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = v.Length -1; i >= 0 ; i--)
            {
                sb.Append(v[i]);
            }

            return sb.ToString();
        }
    }
}
