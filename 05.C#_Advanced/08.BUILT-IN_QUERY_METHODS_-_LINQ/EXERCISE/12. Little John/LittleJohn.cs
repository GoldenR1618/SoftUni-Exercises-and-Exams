namespace _12.Little_John
{
    using System;

    public class LittleJohn
    {
        public static void Main(string[] args)
        {
            string largeArrow = ">>>----->>";
            string mediumArrow = ">>----->";
            string smallArrow = ">----->";

            string input = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                input += " " + Console.ReadLine();
            }

            int countLarge = GetCountOfString(input, largeArrow);
            input = input.Replace(largeArrow, " ");

            int countMedium = GetCountOfString(input, mediumArrow);
            input = input.Replace(mediumArrow, " ");

            int countSmall = GetCountOfString(input, smallArrow);
            input = input.Replace(smallArrow, " ");

            string numberDec = countSmall.ToString() + countMedium.ToString() + countLarge.ToString();

            string numberBin = Convert.ToString(Convert.ToInt64(numberDec, 10), 2);

            numberBin = numberBin + ReverseString(numberBin);
            string result = Convert.ToString(Convert.ToInt64(numberBin, 2), 10);

            Console.WriteLine(result);
        }

        public static int GetCountOfString(string stringToCheckIn, string stringToLookFor)
        {
            int count = 0;

            int index = stringToCheckIn.IndexOf(stringToLookFor);

            while (index >= 0)
            {
                count++;
                index = stringToCheckIn.IndexOf(stringToLookFor, index + stringToLookFor.Length);
            }

            return count;
        }

        public static string ReverseString(string inputString)
        {
            string outputString = "";

            for (int i = 0; i < inputString.Length; i++)
            {
                outputString = inputString[i] + outputString;
            }

            return outputString;
        }
    }
}
