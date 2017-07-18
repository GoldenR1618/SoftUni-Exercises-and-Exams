using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine("{0:f2}", sales * 0.05);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine("{0:f2}", sales * 0.07);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine("{0:f2}", sales * 0.08);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:f2}", sales * 0.12);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine("{0:f2}", sales * 0.045);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine("{0:f2}", sales * 0.075);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine("{0:f2}", sales * 0.1);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:f2}", sales * 0.13);
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine("{0:f2}", sales * 0.055);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine("{0:f2}", sales * 0.08);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine("{0:f2}", sales * 0.12);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:f2}", sales * 0.145);
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
