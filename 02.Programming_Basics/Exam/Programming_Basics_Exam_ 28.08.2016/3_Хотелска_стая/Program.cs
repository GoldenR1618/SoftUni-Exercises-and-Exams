using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3___Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            var mesec = Console.ReadLine().ToLower();
            int broiNoshtuvki = int.Parse(Console.ReadLine());

            if (mesec == "may" || mesec == "october")
            {
                if (broiNoshtuvki > 7 && broiNoshtuvki <= 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", 65.00 * broiNoshtuvki);
                    Console.WriteLine("Studio: {0:f2} lv.", 50.00 * broiNoshtuvki * 0.95);
                }
                else if (broiNoshtuvki > 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", 65.00 * broiNoshtuvki * 0.90);
                    Console.WriteLine("Studio: {0:f2} lv.", 50.00 * broiNoshtuvki * 0.70);
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", 65.00 * broiNoshtuvki);
                    Console.WriteLine("Studio: {0:f2} lv.", 50.00 * broiNoshtuvki);
                }
            }

            if (mesec == "june" || mesec == "september")
            {
                if (broiNoshtuvki > 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", 68.70 * broiNoshtuvki * 0.90);
                    Console.WriteLine("Studio: {0:f2} lv.", 75.20 * broiNoshtuvki * 0.80);
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", 68.70 * broiNoshtuvki);
                    Console.WriteLine("Studio: {0:f2} lv.", 75.20 * broiNoshtuvki);
                }
            }

            if (mesec == "july" || mesec == "august")
            {
                if (broiNoshtuvki > 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", 77.00 * broiNoshtuvki * 0.90);
                    Console.WriteLine("Studio: {0:f2} lv.", 76.00 * broiNoshtuvki);
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", 77.00 * broiNoshtuvki);
                    Console.WriteLine("Studio: {0:f2} lv.", 76.00 * broiNoshtuvki);

                }
            }
        }
    }
}
