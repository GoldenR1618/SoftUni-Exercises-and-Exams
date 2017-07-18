using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            int ostavenaHranaKilogrami = int.Parse(Console.ReadLine());
            double hranaZaDenKu4eKilogrami = double.Parse(Console.ReadLine());
            double hranaZaDenKotkaKilogrami = double.Parse(Console.ReadLine());
            double htanaZaDenKostenurkaGramove = double.Parse(Console.ReadLine());

            double neobhodimaHrana = dni * hranaZaDenKu4eKilogrami + dni * hranaZaDenKotkaKilogrami + dni * htanaZaDenKostenurkaGramove / 1000;
            double kilogramaOstatak = ostavenaHranaKilogrami - neobhodimaHrana;
            double kilogramaNedostigat = neobhodimaHrana - ostavenaHranaKilogrami;

            if (ostavenaHranaKilogrami >= neobhodimaHrana)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(kilogramaOstatak));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(kilogramaNedostigat));
            }
        }
    }
}
