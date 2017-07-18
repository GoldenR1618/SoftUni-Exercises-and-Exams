using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstText = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondText = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (firstText.Length < secondText.Length)
            {
                Console.WriteLine("{0}\n{1}", string.Join("", firstText), string.Join("", secondText));
            }
            else if (firstText.Length > secondText.Length)
            {
                Console.WriteLine("{0}\n{1}", string.Join("", secondText), string.Join("", firstText));
            }
            else if (firstText.Length == secondText.Length)
            {
                for (int i = 0; i < Math.Min(firstText.Length, secondText.Length); i++)
                {

                    if (firstText[i] > secondText[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", secondText), string.Join("", firstText));
                        break;
                    }
                    if (secondText[i] > firstText[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", firstText), string.Join("", secondText));
                        break;
                    }
                    if (secondText[i] == firstText[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", firstText), string.Join("", secondText));
                        break;
                    }
                }
            }
        }
    }
}
