using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiTovari = int.Parse(Console.ReadLine());
            double mikrobus = 0.00;
            double kamion = 0.00;
            double vlak = 0.00;

            for (int i = 1; i <= broiTovari; i++)
            {
                int tonazh = int.Parse(Console.ReadLine());
                if (tonazh <= 3)
                {
                    mikrobus += tonazh;
                }
                else if (tonazh >= 4 && tonazh <= 11)
                {
                    kamion += tonazh;
                }
                else if (tonazh >= 12)
                {
                    vlak += tonazh;
                }
            }
            double sumaTovari = mikrobus + kamion + vlak;
            double srednaCena = (mikrobus * 200 + kamion * 175 + vlak * 120) / sumaTovari;
            double procentMikrobus = mikrobus / sumaTovari * 100;
            double procentKamion = kamion / sumaTovari * 100;
            double procentVlak = vlak / sumaTovari * 100;

            Console.WriteLine("{0:F2}", srednaCena);
            Console.WriteLine("{0:F2}%", procentMikrobus);
            Console.WriteLine("{0:F2}%", procentKamion);
            Console.WriteLine("{0:F2}%", procentVlak);
        }
    }
}
