using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4___Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            int treated = 0;
            int untreated = 0;
            int lekari = 7;

            for (int i = 1; i <= dni; i++)
            {
                int brPacienti = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && treated < untreated)
                {
                    lekari++;
                }

                if (brPacienti > lekari)
                {
                    treated = treated + lekari;
                    untreated = untreated + (brPacienti - lekari);
                }
                else
                {
                    treated = treated + brPacienti;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
