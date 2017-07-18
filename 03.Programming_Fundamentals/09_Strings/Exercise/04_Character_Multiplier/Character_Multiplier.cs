namespace _04_Character_Multiplier
{
    using System;

    public class Character_Multiplier
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string word1 = input[0];
            string word2 = input[1];

            int minLength = Math.Min(word1.Length, word2.Length);
            int maxLength = Math.Max(word1.Length, word2.Length);
            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += MultiplyCharsASCII(word1[i], word2[i]);
            }

            if (word1.Length != word2.Length)
            {
                string longerInput = word1.Length > word2.Length ? longerInput = word1 : longerInput = word2;

                for (int i = minLength; i < maxLength; i++)
                {
                    sum += longerInput[i];
                }
            }

            Console.WriteLine(sum);
        }

        public static int MultiplyCharsASCII(char let1, char let2)
        {
            int multiply = let1 * let2; //Чаровете могат да се умножават като интеджери.
            return multiply;
        }
    }
}
