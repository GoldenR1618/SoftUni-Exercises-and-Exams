namespace _03_Rage_Quit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Text;

    public class RageQuit
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            //--------------Отделяне на думите от цифрите---------------------------------   
            string digits = @"\d+";
            string nonDigits = @"\D+";

            Regex digit = new Regex(digits);
            Regex nonDigit = new Regex(nonDigits);

            MatchCollection digitMatches = digit.Matches(input);
            MatchCollection nonDigitMatches = nonDigit.Matches(input);

            List<int> digitList = new List<int>();

            foreach (Match item in digitMatches)
            {
                digitList.Add(int.Parse(item.Value));
            }

            List<string> nonDigitList = new List<string>();

            foreach (Match index in nonDigitMatches)
            {
                nonDigitList.Add(index.Value);
            }

            //--------------Сглобяване на текста------------------------------------------
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Math.Min(digitList.Count, nonDigitList.Count); i++)
            {
                for (int k = 1; k <= digitList[i]; k++)
                {
                    sb.Append(nonDigitList[i]);
                }
            }

            string output = string.Join("", sb.ToString());

            //--------------Брояч на уникални символи------------------------------------   
            char[] dg = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            HashSet<string> uniqueSymbols = new HashSet<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dg.Contains(input[i]))
                {
                    uniqueSymbols.Add(input[i].ToString());
                }
            }

            //----------------Печат--------------------------------------------------------
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(output);
        }
    }
}
