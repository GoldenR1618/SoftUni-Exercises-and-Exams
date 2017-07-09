namespace _05.Convert_from_base_N_to_base_10
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class ConvertFromBaseNtoBase10
    {
        public static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger n = input[0];
            BigInteger baseNnumber = input[1];

            Console.WriteLine(FromBaseNtoBase10Converter(n, baseNnumber));
        }

        public static BigInteger FromBaseNtoBase10Converter(BigInteger n, BigInteger baseNnumber)
        {
            string strBaseNnumber = baseNnumber.ToString();

            BigInteger result = 0;

            for (int i = strBaseNnumber.Length - 1, j = 0; i >= 0; i--, j++)
            {
                int num = int.Parse(strBaseNnumber[i].ToString());
                BigInteger pow = 1;

                for (int k = 1; k <= j; k++)
                {
                    pow *= n;
                }

                result += num * pow;
            }

            return result;
        }
    }
}
