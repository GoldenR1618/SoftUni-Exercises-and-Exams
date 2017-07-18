using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int ziumbiuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());
            double result = (magnolii * 3.25 + ziumbiuli * 4.00 + rozi * 3.50 + kaktusi * 8.00) * 0.95;
            double ostanali = Math.Abs(result - priceGift);

            if (result >= priceGift)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(ostanali));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(ostanali));

            }
        }
    }
}
