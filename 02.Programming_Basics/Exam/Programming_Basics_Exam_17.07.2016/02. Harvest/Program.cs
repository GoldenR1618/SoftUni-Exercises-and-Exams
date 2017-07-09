using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int лозеВквМетри = int.Parse(Console.ReadLine());
            double гроздеЗаЕдинКвМетър = double.Parse(Console.ReadLine());
            int нужниЛитриВиноЗаПродан = int.Parse(Console.ReadLine());
            int бройРаботници = int.Parse(Console.ReadLine());

            double произведеноВино = (лозеВквМетри * гроздеЗаЕдинКвМетър / 2.5) * 0.4;
            double недостигащоВино = нужниЛитриВиноЗаПродан - произведеноВино;
            double оставащоВино = произведеноВино - нужниЛитриВиноЗаПродан;
            double виноЗаЕдинРаботник = оставащоВино / бройРаботници;

            if (произведеноВино < нужниЛитриВиноЗаПродан)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(недостигащоВино));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(произведеноВино));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(оставащоВино), Math.Ceiling(виноЗаЕдинРаботник));
            }
        }
    }
}
