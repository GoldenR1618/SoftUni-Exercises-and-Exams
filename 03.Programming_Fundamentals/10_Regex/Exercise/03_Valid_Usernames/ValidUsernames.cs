namespace _03_Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b";

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(text);

            int sum = 0;
            int maxSum = 0;
            string firstUser = "";
            string secondUser = "";

            for (int i = 0; i < matchCollection.Count - 1; i++)
            {
                sum = matchCollection[i].Length + matchCollection[i + 1].Length;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    firstUser = matchCollection[i].ToString();
                    secondUser = matchCollection[i + 1].ToString();
                }
            }

            Console.WriteLine(firstUser);
            Console.WriteLine(secondUser);
        }
    }
}
