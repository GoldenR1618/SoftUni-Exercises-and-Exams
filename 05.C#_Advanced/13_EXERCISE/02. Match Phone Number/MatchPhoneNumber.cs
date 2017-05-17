namespace _02.Match_Phone_Number
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"^\+359-\d-\d{3}-\d{4}$");
            Regex regexTwo = new Regex(@"^\+359 \d \d{3} \d{4}$");

            while (text != "end")
            {
                if (regex.IsMatch(text) || regexTwo.IsMatch(text))
                {
                    Console.WriteLine(text);
                }

                text = Console.ReadLine();
            }
        }
    }
}
