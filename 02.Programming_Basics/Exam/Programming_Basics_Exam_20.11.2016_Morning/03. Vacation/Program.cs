using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int vazrastni = int.Parse(Console.ReadLine());
            int u4enici = int.Parse(Console.ReadLine());
            int no6tuvki = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine().ToLower();

            double razhod = 0.00;

            switch (transport)
            {
                case "train":
                    if (vazrastni + u4enici >= 50)
                        razhod = ((vazrastni * 24.99 + u4enici * 14.99) * 2 * 0.50 + no6tuvki * 82.99) * 1.1;
                    else
                        razhod = ((vazrastni * 24.99 + u4enici * 14.99) * 2 + no6tuvki * 82.99) * 1.1;
                    break;
                case "bus":
                    razhod = ((vazrastni * 32.50 + u4enici * 28.50) * 2 + no6tuvki * 82.99) * 1.1;
                    break;
                case "boat":
                    razhod = ((vazrastni * 42.99 + u4enici * 39.99) * 2 + no6tuvki * 82.99) * 1.1;
                    break;
                case "airplane":
                    razhod = ((vazrastni * 70.00 + u4enici * 50.00) * 2 + no6tuvki * 82.99) * 1.1;
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0:F2}", razhod);
        }
    }
}
