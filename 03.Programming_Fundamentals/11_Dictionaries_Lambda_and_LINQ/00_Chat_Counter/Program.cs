using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Chat_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Ivancho otide na uchilishte i mu pisaha dvoika".ToLower().Replace(" ", String.Empty);

            SortedDictionary<char, int> result = new SortedDictionary<char, int>();

            foreach (var symbol in text)
            {
                if (result.ContainsKey(symbol))
                {
                    result[symbol]++;
                }
                else
                {
                    result[symbol] = 1;
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
