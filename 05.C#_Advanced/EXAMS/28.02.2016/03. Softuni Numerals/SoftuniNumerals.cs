namespace _03.Softuni_Numerals
{
    using System;
    using System.Numerics;

    public class SoftuniNumerals
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] codes = { "aa", "aba", "bcc", "cc", "cdc" };

            string result = string.Empty;

            while (input.Length > 0)
            {
                for (int i = 0; i < codes.Length; i++)
                {
                    string currentCode = codes[i];

                    if (input.StartsWith(currentCode))
                    {
                        result += i;
                        input = input.Substring(currentCode.Length);
                        break;
                    }
                }
            }

            Console.WriteLine(FromBase5toBase10Converter(BigInteger.Parse(result)));
        }

        public static BigInteger FromBase5toBase10Converter(BigInteger number)
        {
            string strBaseNnumber = number.ToString();

            BigInteger result = 0;

            for (int i = strBaseNnumber.Length - 1, j = 0; i >= 0; i--, j++)
            {
                int num = int.Parse(strBaseNnumber[i].ToString());
                BigInteger pow = 1;

                for (int k = 1; k <= j; k++)
                {
                    pow *= 5;
                }

                result += num * pow;
            }

            return result;
        }
    }
}
