using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Броене_на_букви_в_текст
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();   //Броим само малките букви, без интервалите.

            int[] count = new int[26];

            foreach (var symbol in text)
            {
                if (char.IsLetter(symbol))  //Ако чара е буква.
                {
                    count[symbol - 'a']++;
                }
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)           //Само преброените символи.
                {
                    Console.WriteLine($"{(char)(i + 'a')} - {count[i]}");
                }
            }
        }
    }
}
