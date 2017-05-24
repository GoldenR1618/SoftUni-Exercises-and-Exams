namespace _13.Magic_exchangeable_words
{
    using System;
    using System.Collections.Generic;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            bool result = AreTwoStringsExchangeable(input);
            Console.WriteLine(result.ToString().ToLower());
        }

        public static bool AreTwoStringsExchangeable(string[] input)
        {
            string firstStr = input[0];
            string secondStr = input[1];
            string shorter = "";
            string longer = "";

            if (firstStr.Length <= secondStr.Length)
            {
                shorter = firstStr;
                longer = secondStr;
            }
            else
            {
                shorter = secondStr;
                longer = firstStr;
            }

            Dictionary<char, char> mappings = new Dictionary<char, char>();

            int length = Math.Min(firstStr.Length, secondStr.Length);
            bool areExchangeable = true;


            for (int i = 0; i < length; i++)
            {
                if (!mappings.ContainsKey(firstStr[i]) && !mappings.ContainsValue(secondStr[i]))
                {
                    mappings[firstStr[i]] = secondStr[i];
                }
                else
                {

                    if (mappings.ContainsKey(firstStr[i]))
                    {
                        if (mappings[firstStr[i]] != secondStr[i])
                        {
                            areExchangeable = false;
                            return areExchangeable;
                        }
                    }

                    else if (mappings.ContainsValue(secondStr[i]))
                    {
                        areExchangeable = false;
                        return areExchangeable;
                    }
                }
            }

            string remainingLetters = longer.Substring(length);

            foreach (char letter in remainingLetters)
            {
                if (!mappings.ContainsKey(letter) && !mappings.ContainsValue(letter))
                {
                    areExchangeable = false;
                    return areExchangeable;
                }
            }

            return areExchangeable;
        }
    }
}
