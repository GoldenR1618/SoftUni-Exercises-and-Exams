namespace _01_Convert_from_base_10_to_base_N
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Numerics;
    

    public class Convertfrombase10tobaseN
    {
        public static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger n = input[0];
            BigInteger decNumber = input[1];

            Console.WriteLine(FromBase10toBaseNconverter(n, decNumber));
        }

        public static string FromBase10toBaseNconverter(BigInteger n, BigInteger decNumber)
        {
            StringBuilder rs = new StringBuilder();

            while (decNumber > 0)
            {
                BigInteger rem = decNumber % n;
                rs.Append(rem);
                decNumber = decNumber / n;
            }

            string str = rs.ToString();
            StringBuilder result = new StringBuilder();

            for (int i = str.Length-1; i >= 0; i--)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }
    }
}
