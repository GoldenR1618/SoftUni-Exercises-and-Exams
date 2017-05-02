namespace _08_Letters_Change_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class LettersChangeNumbers
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] text = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> textList = new List<string>();
            List<int> onlyNumbers = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                textList.Add(text[i]);
            }


            string pattern = @"[0-9]+";
            Regex rgx = new Regex(pattern);
            for (int i = 0; i < textList.Count; i++)
            {
                Match mth = rgx.Match(textList[i]);
                string a = Convert.ToString(mth.Groups[0]);
                int number = int.Parse(a);
                onlyNumbers.Add(number);
            }

            double sum = 0;
            double sum1 = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i][0]))
                {
                    double convert = (double)Convert.ToChar(text[i][0]);
                    sum1 = onlyNumbers[i] / (convert - 64.0);
                }
                else
                {
                    double convert = (double)Convert.ToChar(text[i][0]);
                    sum1 = onlyNumbers[i] * (convert - 96.0);
                }
                if (char.IsUpper(text[i][text[i].Length - 1]))
                {
                    double convert = (double)Convert.ToChar(text[i][text[i].Length - 1]);
                    sum += sum1 - (convert - 64.0);
                }
                else
                {
                    double convert = (double)Convert.ToChar(text[i][text[i].Length - 1]);
                    sum += sum1 + (convert - 96.0);
                }
            }

            Console.WriteLine("{0:F2}", sum);
        }
    }
}
