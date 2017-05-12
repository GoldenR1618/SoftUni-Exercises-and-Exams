namespace _08.Multiply_big_number
{
    using System;
    using System.Text;

    public class MultiplyBigNumber
    {
        public static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            Console.WriteLine(MultiplyRealyBigNumber(num1, num2));
        }

        private static string MultiplyRealyBigNumber(string num1, string num2)
        {
            int n2 = int.Parse(num2.ToString());

            if (n2 == 0)
            {
                return "0";
            }

            int p = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int n1 = int.Parse(num1[i].ToString());
                int mult = (n2 * n1) + p;
                p = mult / 10;
                string result = mult.ToString();
                sb.Append(result[result.Length - 1].ToString());
            }

            sb.Append(p.ToString());

            return Reverse(sb.ToString()).TrimStart('0');
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
