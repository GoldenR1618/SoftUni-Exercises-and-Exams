namespace _07_Multiply_big_number
{
    using System;
    using System.Text;

    public class MultiplyBigNumber
    {
        public static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            int transferDigit = 0;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int currentSum = int.Parse(num1[i].ToString()) * num2 + transferDigit;
                transferDigit = currentSum / 10;
                int resultDigit = currentSum % 10;

                sb.Append(resultDigit);
            }

            if (transferDigit > 0)
            {
                sb.Append(transferDigit);
            }

            string result = sb.ToString();

            StringBuilder rsb = new StringBuilder();

            for (int i = result.Length - 1; i >= 0; i--)
            {
                rsb.Append(result[i]);
            }

            result = rsb.ToString().TrimStart('0');

            if (num2 == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
