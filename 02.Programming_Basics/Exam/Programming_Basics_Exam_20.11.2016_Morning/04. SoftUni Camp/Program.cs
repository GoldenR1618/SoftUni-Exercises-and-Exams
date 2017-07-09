using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int broyGrupi = int.Parse(Console.ReadLine());

            double kola = 0.00;
            double mikrobus = 0.00;
            double mAvtobus = 0.00;
            double gAvtobus = 0.00;
            double vlak = 0.00;
            double vsi4kiHora = 0.00;

            for (int i = 1; i <= broyGrupi; i++)
            {
                double horaVgrupata = double.Parse(Console.ReadLine());

                vsi4kiHora += horaVgrupata;

                if (horaVgrupata <= 5)
                {
                    kola += horaVgrupata;
                }
                else if (horaVgrupata >= 6 && horaVgrupata <= 12)
                {
                    mikrobus += horaVgrupata;
                }
                else if (horaVgrupata >= 13 && horaVgrupata <= 25)
                {
                    mAvtobus += horaVgrupata;
                }
                else if (horaVgrupata >= 26 && horaVgrupata <= 40)
                {
                    gAvtobus += horaVgrupata;
                }
                else
                {
                    vlak += horaVgrupata;
                }
            }
            Console.WriteLine("{0:F2}%", kola / vsi4kiHora * 100);
            Console.WriteLine("{0:F2}%", mikrobus / vsi4kiHora * 100);
            Console.WriteLine("{0:F2}%", mAvtobus / vsi4kiHora * 100);
            Console.WriteLine("{0:F2}%", gAvtobus / vsi4kiHora * 100);
            Console.WriteLine("{0:F2}%", vlak / vsi4kiHora * 100);
        }
    }
}
