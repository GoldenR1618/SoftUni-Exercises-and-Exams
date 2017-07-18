namespace _06_Sum_big_numbers
{
    using System;
    using System.Text;

    public class SumBigNumbers
    {
        public static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            string biggerNum = "";
            string smallerNum = "";
            
            if (num1.Length >= num2.Length)
            {
                biggerNum = num1;
                smallerNum = num2;
            }
            else
            {
                biggerNum = num2;
                smallerNum = num1;
            }

            smallerNum = new string('0', (biggerNum.Length - smallerNum.Length)) + smallerNum;

            StringBuilder sb = new StringBuilder();

            int transferDigit = 0;

            for (int i = biggerNum.Length - 1; i >= 0; i--)
            {
                int currentSum = int.Parse(biggerNum[i].ToString()) + int.Parse(smallerNum[i].ToString()) + transferDigit;
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
            
            Console.WriteLine(result);
        }
    }
}
