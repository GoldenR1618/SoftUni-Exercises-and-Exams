using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaSkumria = double.Parse(Console.ReadLine());
            double cenaCaca = double.Parse(Console.ReadLine());
            double palamud = double.Parse(Console.ReadLine());
            double safrid = double.Parse(Console.ReadLine());
            int midi = int.Parse(Console.ReadLine());

            double cenaPalamud = cenaSkumria * 1.60;
            double cenaSafrid = cenaCaca * 1.80;
            double cenaMidi = 7.50;

            double smetka = palamud * cenaPalamud + cenaSafrid * safrid + midi * cenaMidi; 
            Console.WriteLine("{0:F2}", smetka);
        }
    }
}
