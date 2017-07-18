using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double parvonSkorost = int.Parse(Console.ReadLine());
            double parvoVremeMinuti = int.Parse(Console.ReadLine());
            double vtoroVremeMinuti = int.Parse(Console.ReadLine());
            double tretoVremeMinuti = int.Parse(Console.ReadLine());

            double parvoVreme4as = parvoVremeMinuti / 60;
            double vtoroVreme4as = vtoroVremeMinuti / 60;
            double tretoVreme4as = tretoVremeMinuti / 60;

            double a = parvonSkorost * parvoVreme4as;
            double b = parvonSkorost * 1.1 * vtoroVreme4as;
            double c = parvonSkorost * 1.1 * 0.95 * tretoVreme4as;

            double izminatiKilometri = a + b + c;

            Console.WriteLine("{0:F2}", izminatiKilometri);
        }
    }
}
