using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hands_of_Cards
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> dictNameCards = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                List<string> input = Console.ReadLine()
                .Split(new char[] { ',', ':', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                if (input[0] == "JOKER")
                {
                    break;
                }

                string name = input[0];
                List<string> listCards = input.Skip(1).ToList();

                if (dictNameCards.ContainsKey(name))
                {
                    foreach (var listCardsItem in listCards)
                    {
                        dictNameCards[name].Add(listCardsItem);
                    }  
                }
                else
                {
                    dictNameCards[name] = new HashSet<string>();

                    foreach (var listCardsItem in listCards)
                    {
                        dictNameCards[name].Add(listCardsItem);
                    }
                }
            }

            foreach (var dictNameCardsItem in dictNameCards)
            {
                Console.WriteLine("{0}: {1}", dictNameCardsItem.Key, PowerTypeCalcSum(dictNameCardsItem.Value));
            }
        }

        private static int PowerTypeCalcSum(HashSet<string> value)
        {
            int sum = 0;

            foreach (var valueItem in value)
            {
                int power = 0;
                int type = 0;

                if (valueItem.Length > 2)
                {
                    power = 10;

                    switch (valueItem[2])
                    {
                        case 'S': type = 4; break;
                        case 'H': type = 3; break;
                        case 'D': type = 2; break;
                        case 'C': type = 1; break;
                        default: break;
                    }
                }
                else
                {
                    switch (valueItem[0])
                    {
                        case '1': power = 1; break;
                        case '2': power = 2; break;
                        case '3': power = 3; break;
                        case '4': power = 4; break;
                        case '5': power = 5; break;
                        case '6': power = 6; break;
                        case '7': power = 7; break;
                        case '8': power = 8; break;
                        case '9': power = 9; break;
                        case 'J': power = 11; break;
                        case 'Q': power = 12; break;
                        case 'K': power = 13; break;
                        case 'A': power = 14; break;
                        default: break;
                    }

                    switch (valueItem[1])
                    {
                        case 'S': type = 4; break;
                        case 'H': type = 3; break;
                        case 'D': type = 2; break;
                        case 'C': type = 1; break;
                        default: break;
                    }
                }

                sum = sum + (power * type);
            }

            return sum;
        }
    }
}
