using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hands_of_Cards_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictCardPowers = GetCardPower();    //Дефинираме речник, където ще държим Powers (символ, числова стойност).
            Dictionary<string, int> dictCardTypes = GetCardTypes();     //Дефинираме речник, където ще държим Types (символ, числова стойност).

            Dictionary<string, HashSet<int>> dictNamecards = new Dictionary<string, HashSet<int>>();    //Дефинираме речник където ще държим
                                                                                                        //имената и стойността на картите.
                                                                                                        //HashSet пропуска дублиращи се стойности.
            string line = Console.ReadLine();       //Прочитаме първата линия и я записваме с string.

            while (line != "JOKER")                 //Проверяваме дали въведената линия е "JOKER". Изпълнява се докато не срещнем "JOKER".
            {
                string[] tokens = line.Split(':');  //Сплитваме с ':' и записваме в string масив. Така отделяме на името от всичко останало.

                string name = tokens[0];            //Записваме името, което се съдържа в първата клетка на масива в променлива от тип string.

                string[] playerCards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);  //Сплитваме по ", ".
                                                                                        //ToCharArray() е за да сплитне последователнопо
                                                                                        //двата символа в скобите. Следващото маха "нищото"
                                                                                        //между сплитнатите стрингове. Записваме в string масив.

                foreach (var card in playerCards)                                       //Обхождаме с foreach string масива playerCards за да
                {
                    string cardPower = card.Substring(0, card.Length - 1);              //Присвояваме на cardPower първият символ.
                    string cardType = card.Substring(card.Length - 1);                  //Присвояваме на cardType вторият символ.

                    int sum = dictCardPowers[cardPower] * dictCardTypes[cardType];       //Изчисляваме powers * Types в int променлива.

                    if (!dictNamecards.ContainsKey(name))                               //Проверяваме дали имаме такова име.
                    {
                        dictNamecards[name] = new HashSet<int>();                       //Ако няма - създаваме нов HashSet за това име.
                    }

                    dictNamecards[name].Add(sum);                                       //Добавяме резултата към съответното име.
                }

                line = Console.ReadLine();                                              //Викаме конзолата за следващ ред.
            }

            //Приключваме с въвеждането на редове.

            foreach (var pair in dictNamecards)                                         //Обхождаме речника с имена и масив от картите.
            {
                string name = pair.Key;                                                 //Извежда името.
                int cardsSum = pair.Value.Sum();                                        //Извежда сумата от всички стойности на картите.

                Console.WriteLine($"{name}: {cardsSum}");                               //Отпечатва името и срещу него сумата на картите.
            }
        }

        private static Dictionary<string, int> GetCardPower()
        {
            Dictionary<string, int> powers = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;
            }

            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;

            return powers;
        }

        private static Dictionary<string, int> GetCardTypes()
        {
            Dictionary<string, int> cardTypes = new Dictionary<string, int>();

            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            return cardTypes;
        }
    }
}
