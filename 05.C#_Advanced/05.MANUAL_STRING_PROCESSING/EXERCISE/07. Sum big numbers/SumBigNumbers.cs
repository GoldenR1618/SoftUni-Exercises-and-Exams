namespace _07.Sum_big_numbers
{
    using System;
    using System.Text;

    public class SumBigNumbers
    {
        public static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            if (num1.Length >= num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }

            Console.WriteLine(SumRealyBigNumber(num1, num2).TrimStart('0'));
        }

        public static string SumRealyBigNumber(string num1, string num2)
        {
            int p = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int n1 = int.Parse(num1[i].ToString());
                int n2 = int.Parse(num2[i].ToString());
                int sum = n1 + n2 + p;
                p = sum / 10;
                string result = sum.ToString();
                sb.Append(result[result.Length-1].ToString());                
            }

            sb.Append(p.ToString());

            return Reverse(sb.ToString());
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
