using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double sabraniPari = double.Parse(Console.ReadLine());
            double shirinaPod = double.Parse(Console.ReadLine());
            double dalzhinaPod = double.Parse(Console.ReadLine());
            double stranaTriagalnik = double.Parse(Console.ReadLine());
            double viso4inaTriagalnik = double.Parse(Console.ReadLine());
            double cenaPlo4ka = double.Parse(Console.ReadLine());
            double sumaMaistor = double.Parse(Console.ReadLine());

            double liceTriagalnik = (stranaTriagalnik * viso4inaTriagalnik) / 2;
            double licePod = shirinaPod * dalzhinaPod;


            double nuzhnuPlo4ki = Math.Ceiling(licePod / liceTriagalnik) + 5;
            double nuzhniPari = nuzhnuPlo4ki * cenaPlo4ka + sumaMaistor;


            double ostava6tiPari = sabraniPari - nuzhniPari;
            double nedostPari = nuzhniPari - sabraniPari;

            if (sabraniPari >= nuzhniPari)
            {
                Console.WriteLine("{0:F2} lv left.", ostava6tiPari);
            }
            else
            {
                Console.WriteLine("You'll need {0:F2} lv more.", nedostPari);
            }
        }
    }
}
