namespace _03.Formatting_Numbers
{
    using System;

    public class FormattingNumbers
    {
        public static void Main(string[] args)
        {
            string[] inputParams = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int a = int.Parse(inputParams[0]);
            double b = double.Parse(inputParams[1]);
            double c = double.Parse(inputParams[2]);

            string hexadecimalNuber = a.ToString("X");
            string result = "|" + hexadecimalNuber.PadRight(10) + "|";
            string binaryNumber = Convert.ToString(a, 2);   //Конвертира зададено число в бройна система ("а" в двоична).

            result = result + binaryNumber.PadLeft(10, '0').Substring(0, 10) + "|";
            result = result + b.ToString("0.00").PadLeft(10) + "|";
            result = result + c.ToString("0.000").PadRight(10) + "|";
            Console.WriteLine(result);
        }
    }
}
