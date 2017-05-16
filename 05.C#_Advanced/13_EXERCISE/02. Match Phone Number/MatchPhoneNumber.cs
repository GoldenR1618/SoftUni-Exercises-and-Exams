namespace _02.Match_Phone_Number
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"^\+\d{3}( |-)\d{1}\1\d{3}\1\d{4}$";
            Regex regex = new Regex(pattern);

            while (text != "end")
            {
                Match matche = regex.Match(text);
                Console.WriteLine(matche.Value);

                text = Console.ReadLine();
            }
        }
    }
}
